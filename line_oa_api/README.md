# 💬 Line OA Integration API (Node.js)

This project is a dedicated middleware built with **Node.js** and **Express.js** to streamline the management of LINE Official Account (OA) features. It demonstrates proficiency in interacting with the **LINE Messaging API**, handling complex message types, and programmatic Rich Menu orchestration.

---

## ⚙️ Tech Stack & Dependencies
- **Runtime:** Node.js
- **Framework:** Express.js
- **API Client:** node-fetch (Handling RESTful requests)
- **Security:** dotenv (Secure environment variable management)

---

## 🚀 Key Features

- **Automated Broadcast Engine:** Trigger multi-format broadcasts including Text, Video, and Flex Carousel messages via a single endpoint.
- **Dynamic Rich Menu Orchestration:**
    - Programmatically create and link multiple Rich Menus (`campaign_page` and `menu_page`).
    - Implement interactive actions: URI redirection, Message triggers, and seamless Menu-switching.
- **Cleanup Utility:** A dedicated maintenance endpoint to clear existing Rich Menus and Aliases, ensuring a clean state for new deployments.
- **Payload Management:** Handles complex JSON structures for LINE Flex Messages and Rich Menu Area objects.

---

## 🛠️ Setup & Execution

1. **Clone & Navigate:**
   ```bash
   git clone https://github.com/savant777/homework-for-new-dev.git
   cd homework-for-new-dev/line_oa_api
   ```

2. **Installation:**
   ```bash
   npm install
   ```

3. **Environment Configuration:**
   Create a `.env` file in the root directory:
   ```env
   PORT=3000
   CHANNEL_ACCESS_TOKEN=your_access_token_here
   ```

4. **Run Server:**
   ```bash
   node littleChat.js
   ```

---

## 🔗 API Documentation

### 📢 Broadcast Messages

`GET /broadcast`

* **Function:** Dispatches a sequence of messages (Text -> Video -> Flex Carousel) to all followers.
* **Flex Carousel:** Features a "DISCOVER" call-to-action for external link redirection.

### 🖼️ Rich Menu Management

`GET /setup-richmenu`

* **Function:** Initializes a dual-menu system with interactive switching logic.
* **Setup:** Creates menu objects, uploads hosted assets, and assigns the default menu to the LINE OA.

`GET /clear-richmenu`

* **Function:** Purges all existing Rich Menus and Aliases to prevent ID conflicts during development.

---

## ℹ️ Technical Implementation Details

* **Authorization:** All requests are secured using Bearer Token authentication via the LINE Messaging API.
* **Asset Handling:** Rich menu images are fetched from remote URLs and streamed to LINE's servers as binary data.
* **Error Prevention:** Includes a `.gitignore` to protect sensitive `.env` credentials and `node_modules`.

---

## ✅ Postman / Browser Testing

* Send Broadcast: `http://localhost:3000/broadcast`
* Initialize Menus: `http://localhost:3000/setup-richmenu`
* Reset Menus: `http://localhost:3000/clear-richmenu`

---

## 📜 License

MIT License
