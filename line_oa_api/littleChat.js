import express from "express";
import fetch from "node-fetch";
import dotenv from "dotenv";

dotenv.config();

const app = express();
const PORT = process.env.PORT || 3000;
const CHANNEL_ACCESS_TOKEN = process.env.CHANNEL_ACCESS_TOKEN;

const imageUrls = [
    "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/1.png",
    "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/2.png",
    "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/3.png",
    "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/4.png"
];

const buttonLink = "https://www.brilliantmillion.com/";

//#region Send Broadcast Function
async function sendBroadcast() {
    try {
        const bubbles = imageUrls.map(url => ({
            type: "bubble",
            body: {
                type: "box",
                layout: "vertical",
                contents: [
                    {
                        type: "image",
                        url: url,
                        size: "full",
                        aspectMode: "cover",
                        aspectRatio: "4:5"
                    },
                    {
                        type: "box",
                        layout: "vertical",
                        contents: [
                            {
                                type: "box",
                                layout: "vertical",
                                contents: [
                                {
                                    type: "button",
                                    action: {
                                    type: "uri",
                                    label: "DISCOVER",
                                    uri: buttonLink
                                    },
                                    height: "sm",
                                    color: "#ffffff"
                                }
                                ],
                                backgroundColor: "#00000040",
                                cornerRadius: "xxl",
                                paddingStart: "xl",
                                paddingEnd: "xl"
                            }
                        ],
                        position: "absolute",
                        justifyContent: "center",
                        alignItems: "center",
                        width: "100%",
                        offsetBottom: "xxl"
                    }
                ],
                paddingAll: "0px"
            }
        }));
        
        const response = await fetch("https://api.line.me/v2/bot/message/broadcast", {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}`
            },
            body: JSON.stringify({
                messages: [

                    // Text message
                    {
                        type: "text",
                        text: "Hello, This is a test message from the LINE API demo."
                    },
          
                    // Video message
                    {
                        type: "video",
                        originalContentUrl: "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/vdo.mp4",
                        previewImageUrl: "https://amphawa-hosting.s3.ap-southeast-1.amazonaws.com/TEST+Broadcasting+line+api/preview.png"
                    },

                    // Carousel message
                    {
                        type: "flex",
                        altText: "Test message from the LINE API demo.",
                        contents: {
                            type: "carousel",
                            contents: bubbles
                        }
                    }
                ]
            })
        });
    
        if (!response.ok) throw new Error(`HTTP error! status: ${response.status}`);
        const data = await response.json();
        console.log("Broadcast success:", data);
    } catch (error) {
        console.error("Error:", error.message);
    }
}
//#endregion

//#region Set Rich Menu Function
const richMenus = [
    {
        name: "campaign_page",
        chatBarText: "#Test2025",
        imageUrl: "https://iili.io/KK3K1tf.png",
        aliasId: "richmenu-alias-campaign",
        areas: [
            {
                bounds: { x: 1250, y: 0, width: 1250, height: 220 },
                action: { type: "richmenuswitch", richMenuAliasId: "richmenu-alias-menu", data: "richmenu-changed-to-menu" }
            },
            {
                bounds: { x: 0, y: 220, width: 1667, height: 1466 },
                action: { type: "uri", label: "Main Campaign", uri: "https://www.brilliantmillion.com/" }
            },
            {
                bounds: { x: 1667, y: 220, width: 833, height: 733 },
                action: { type: "uri", label: "Youtube", uri: "https://www.youtube.com/" }
            },
            {
                bounds: { x: 1667, y: 953, width: 833, height: 733 },
                action: { type: "uri", label: "Google", uri: "https://www.google.com/" }
            }
        ]
    },
    {
        name: "menu_page",
        chatBarText: "#Test2025",
        imageUrl: "https://iili.io/KK3KMMl.png",
        aliasId: "richmenu-alias-menu",
        areas: [
            {
                bounds: { x: 0, y: 0, width: 1250, height: 220 },
                action: { type: "richmenuswitch", richMenuAliasId: "richmenu-alias-campaign", data: "richmenu-changed-to-campaign" }
            },
            {
                bounds: { x: 0, y: 220, width: 834, height: 733 },
                action: { type: "message", label: "Hello", text: "Hello" }
            },
            {
                bounds: { x: 834, y: 220, width: 833, height: 733 },
                action: { type: "uri", label: "Spotify", uri: "https://open.spotify.com/" }
            },
            {
                bounds: { x: 1667, y: 220, width: 833, height: 733 },
                action: { type: "uri", label: "Pinterest", uri: "https://www.pinterest.com/" }
            },
            {
                bounds: { x: 0, y: 953, width: 834, height: 733 },
                action: { type: "uri", label: "TikTok", uri: "https://www.tiktok.com/" }
            },
            {
                bounds: { x: 834, y: 953, width: 833, height: 733 },
                action: { type: "uri", label: "Netflix", uri: "https://www.netflix.com/" }
            },
            {
                bounds: { x: 1667, y: 953, width: 833, height: 733 },
                action: { type: "uri", label: "Instagram", uri: "https://www.instagram.com/" }
            }
        ]
    }
];

async function createRichMenu(menu) {
    const data = {
        size: { width: 2500, height: 1686 },
        selected: false,
        name: menu.name,
        chatBarText: menu.chatBarText,
        areas: menu.areas
    };

    const res = await fetch("https://api.line.me/v2/bot/richmenu", {
        method: "POST",
        headers: {
            "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}`,
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    });

    if (!res.ok) throw new Error(`Create ${menu.name} failed: ${res.status}`);
    const json = await res.json();
    console.log(`${menu.name} created: ${json.richMenuId}`);
    return json.richMenuId;
}

async function uploadRichMenuImage(richMenuId, imageUrl) {
    const imageRes = await fetch(imageUrl);
    if (!imageRes.ok) throw new Error(`Fetch image failed: ${imageRes.status}`);
    const buffer = await imageRes.arrayBuffer();

    const res = await fetch(`https://api-data.line.me/v2/bot/richmenu/${richMenuId}/content`, {
        method: "POST",
        headers: {
            "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}`,
            "Content-Type": "image/png"
        },
        body: Buffer.from(buffer)
    });

    if (!res.ok) throw new Error(`Upload image failed: ${res.status}`);
    console.log(`Image uploaded for ${richMenuId}`);
}

async function createAlias(richMenuId, aliasId) {
    const data = { richMenuId, richMenuAliasId: aliasId };
    const res = await fetch("https://api.line.me/v2/bot/richmenu/alias", {
        method: "POST",
        headers: {
            "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}`,
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    });

    if (!res.ok) throw new Error(`Create alias ${aliasId} failed: ${res.status}`);
    console.log(`Alias ${aliasId} created`);
}

async function setDefaultRichMenu(richMenuId) {
    const res = await fetch(`https://api.line.me/v2/bot/user/all/richmenu/${richMenuId}`, {
        method: "POST",
        headers: { "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}` }
    });
    if (!res.ok) throw new Error(`Set default failed: ${res.status}`);
    console.log(`Rich Menu ${richMenuId} set as default`);
}

async function setupRichMenu() {
    try {
        const richMenuIds = [];
        for (const menu of richMenus) {
            const id = await createRichMenu(menu);
            await uploadRichMenuImage(id, menu.imageUrl);
            await createAlias(id, menu.aliasId);
            richMenuIds.push({ ...menu, id });
        }

        await setDefaultRichMenu(richMenuIds[0].id);
        console.log("Set up Rich Menu completed!");
    } catch (err) {
        console.error("Error:", err.message);
    }
}
//#endregion

//#region Clear Rich Menu and Alias
async function listAliases() {
    const res = await fetch("https://api.line.me/v2/bot/richmenu/alias/list", {
        method: "GET",
        headers: { "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}` }
    });

    if (!res.ok) throw new Error(`Get alias list failed: ${res.status}`);
    return await res.json();
}

async function deleteAlias(aliasId) {
    const res = await fetch(`https://api.line.me/v2/bot/richmenu/alias/${aliasId}`, {
        method: "DELETE",
        headers: { "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}` }
    });

    if (!res.ok) throw new Error(`Delete alias ${aliasId} failed: ${res.status}`);
    console.log(`Alias deleted: ${aliasId}`);
}

async function listRichMenus() {
    const res = await fetch("https://api.line.me/v2/bot/richmenu/list", {
        method: "GET",
        headers: { "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}` }
    });

    if (!res.ok) throw new Error(`Get rich menu list failed: ${res.status}`);
    return await res.json();
}

async function deleteRichMenu(richMenuId) {
    const res = await fetch(`https://api.line.me/v2/bot/richmenu/${richMenuId}`, {
        method: "DELETE",
        headers: { "Authorization": `Bearer ${CHANNEL_ACCESS_TOKEN}` }
    });

    if (!res.ok) throw new Error(`Delete rich menu ${richMenuId} failed: ${res.status}`);
    console.log(`RichMenu deleted: ${richMenuId}`);
}

async function clearRichMenu() {
    try {
        const aliases = await listAliases();
        if (aliases.aliases && aliases.aliases.length > 0) {
        for (const alias of aliases.aliases) {
            await deleteAlias(alias.richMenuAliasId);
        }
        } else {
            console.log("No aliases found");
        }
        
        const richmenus = await listRichMenus();
        if (richmenus.richmenus && richmenus.richmenus.length > 0) {
            for (const rm of richmenus.richmenus) {
                await deleteRichMenu(rm.richMenuId);
            }
        } else {
            console.log("No rich menus found");
        }

        console.log("All aliases & rich menus deleted!");
    } catch (err) {
        console.error("Error:", err.message);
    }
}
//#endregion

// API route for Broadcast
app.get("/broadcast", async (req, res) => {
    try {
        await sendBroadcast();
        res.json({ status: "success", message: "Broadcast sent" });
    } catch (err) {
        res.status(500).json({ status: "error", message: err.message });
    }
});

// API route for Set up Rich Menu
app.get("/setup-richmenu", async (req, res) => {
    try {
        await setupRichMenu();
        res.json({ status: "success", message: "RichMenu created" });
    } catch (err) {
        res.status(500).json({ status: "error", message: err.message });
    }
});

// API route for Clear Rich Menu and Alias
app.get("/clear-richmenu", async (req, res) => {
    try {
        await clearRichMenu();
        res.json({ status: "success", message: "RichMenu & Aliases deleted" });
    } catch (err) {
        res.status(500).json({ status: "error", message: err.message });
    }
});

app.listen(PORT, () =>
    console.log(`Server running at http://localhost:${PORT}`)
);