# Exercise 2: Line OA API

This project is part of the **Homework for New Dev** assignment.  
It demonstrates integrating a LINE Official Account with Node.js and Express, supporting both **broadcast messaging** and **Rich Menu management**.

---

## 📂 Project Structure
```

line\_oa\_api/
├── littleChat.js         # Main application file
├── package.json          # Project dependencies and scripts
├── package-lock.json     # Dependency lock file
└── README.md

````

---

## ⚙️ Tech Stack
- Node.js
- Express.js
- dotenv (for environment variables)
- node-fetch (for calling LINE Messaging API)

---

## 🚀 Setup & Run

1. Clone the repository and navigate to this folder:
   ```bash
   git clone https://github.com/savant777/homework-for-new-dev.git
   cd homework-for-new-dev/line_oa_api
   ```

2. Install dependencies:

   ```bash
   npm install
   ```

3. Create an `.env` file in this folder with the following variables:

   ```
   PORT=3000
   CHANNEL_ACCESS_TOKEN=your_channel_access_token_here
   ```

4. Start the server:

   ```bash
   npm start
   ```

5. The server will run at:

   ```
   http://localhost:3000
   ```

---

## 🔗 API Endpoints

### 1. Broadcast Messages

Send **text**, **video**, and **flex carousel** messages to all users.

```
GET /broadcast
```

**Response:**

```json
{
  "status": "success",
  "message": "Broadcast sent"
}
```

The broadcast includes:

* Text message
* Video message (with preview image)
* Flex carousel with images + "DISCOVER" button link

---

### 2. Setup Rich Menu

Create and assign multiple **Rich Menus** with actions (URI links, switch menus, messages).

```
GET /setup-richmenu
```

**Response:**

```json
{
  "status": "success",
  "message": "RichMenu created"
}
```

* Two rich menus (`campaign_page`, `menu_page`) are created.
* Each menu has different clickable areas (e.g., open website, send message, switch menus).
* The first menu is set as the default Rich Menu.

---

### 3. Clear Rich Menu & Aliases

Delete all existing **Rich Menus** and **Aliases** from the LINE account.

```
GET /clear-richmenu
```

**Response:**

```json
{
  "status": "success",
  "message": "RichMenu & Aliases deleted"
}
```

This ensures a clean reset before setting up new menus.

---

## 📝 Notes

* **Main entry point**: `littleChat.js`
* Rich menu images are hosted externally and fetched via URL before uploading to LINE API.
* API calls use `fetch` with proper authorization headers (`Bearer CHANNEL_ACCESS_TOKEN`).
* `.gitignore` should exclude sensitive files like `.env` and `node_modules/`.
* Make sure your LINE Official Account has the **Messaging API** enabled.

---

## ✅ Example Usage

1. Start the server:

   ```bash
   npm start
   ```
2. Open browser or use a tool like **Postman**:

   * `http://localhost:3000/broadcast` → send broadcast message
   * `http://localhost:3000/setup-richmenu` → create new rich menus
   * `http://localhost:3000/clear-richmenu` → delete all menus and aliases
