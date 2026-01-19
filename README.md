<div align="center">
  <img src="https://upload.wikimedia.org/wikipedia/en/0/0a/Flappy_Bird_icon.png" width="100" height="100" alt="Flappy Bird Icon">
  <h1>🐦 Course Project: Flappy Bird Clone</h1>
  <p>An original 2D game development project built with Unity.</p>
  <img src="https://img.shields.io/badge/Unity-2022.3+-black?logo=unity&logoColor=white&style=for-the-badge" alt="Unity Version">
  <img src="https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#">
</div>

---

## 📌 Table of Contents
- [🚀 Overview](#-overview)
- [🛠 Tech Stack](#-tech-stack)
- [🎮 Key Features](#-key-features)
- [💻 Setup Guide](#-setup-guide)
- [📖 Detailed Documentation](#-detailed-documentation)
- [📦 Dependencies](#-dependencies)
- [🕹 Controls](#-controls)
- [🎨 Art & Design](#-art--design)
- [⚖️ Development Criteria](#-development-criteria)

---

## 🚀 Overview
This project is a Flappy Bird-like game clone developed as part of a hands-on examination. The objective is to control an original character navigating through a series of obstacles by "flapping" to stay airborne. The game emphasizes:
- **Originality:** Custom characters, backgrounds, and UI.
- **Physics-based Gameplay:** Precise vertical movement and collision detection.
- **Dynamic Difficulty:** Randomized obstacle spawning and positioning.

---

## 🛠 Tech Stack
| Category | Technology |
| :--- | :--- |
| **Engine** | ![Unity](https://img.shields.io/badge/Unity-black?style=flat-square&logo=unity&logoColor=white) Unity (2D) |
| **Language** | ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white) C# (.NET) |
| **Graphics** | 🎨 Custom Sprites / Sprite Sheets |
| **Platform** | 💻 PC (Build target) |

---

## 🎮 Key Features
- [x] **Original Character:** Animated character with custom flight physics.
- [x] **Procedural Obstacles:** Randomized pipes/obstacles spawning at regular intervals.
- [x] **Main Menu:** UI-driven start and quit functionality.
- [x] **Scoring System:** Incremental score tracking as players pass obstacles.
- [x] **Game Over Loop:** Display final score with an instant restart mechanic.
- [x] **Audio:** Integrated sound effects for flapping, collisions, and scoring.

---

## 💻 Setup Guide 🛠️

For a quick start, follow the steps below. For comprehensive instructions, please refer to the [📖 Detailed Documentation](#-detailed-documentation).

### 1. Prerequisites
- [Unity Hub](https://unity.com/download) installed.
- [Unity Editor](https://unity.com/releases/editor/whats-new/2022.3.0f1) ![Unity](https://img.shields.io/badge/Unity-black?style=flat-square&logo=unity&logoColor=white) (Version 2022.3 LTS or newer recommended).

### 2. Installation
1. Clone the repository (or extract the project folder).
2. Open **Unity Hub**.
3. Click **Add** -> **Add project from disk**.
4. Select the project folder.

---

## 📖 Detailed Documentation

For in-depth guides on setting up and running the project, explore the following sections:

- [**Prerequisites**](docs/prerequisites.md): System and software requirements.
- [**Project Setup**](docs/setup.md): Step-by-step project creation and script importing.
- [**Scene Setup**](docs/scene_setup.md): detailed scene configuration for the Bird, Pipes, and Game Manager.
- [**Build and Run**](docs/build_and_run.md): How to configure build settings and test the game.
- [**Controls Guide**](docs/controls.md): Full list of gameplay inputs.
- [**Assets Management**](docs/assets.md): Information on pre-installed sprites and adding custom assets.

---

## 📦 Dependencies 🔗
- **Unity 2D Template:** ![Unity](https://img.shields.io/badge/Unity-black?style=flat-square&logo=unity&logoColor=white) Core engine components for 2D physics and rendering.
- **TextMeshPro:** (Recommended) for high-quality UI text rendering.
- **Original Assets:** All sprites, animations, and audio clips must be imported into the `Assets/` directory.

---

## 🕹 Controls
| Action | Input |
| :--- | :--- |
| **Flap/Fly** | `Mouse Left Click` / `Spacebar` / `Touch` |
| **Navigate Menu** | `Mouse Click` |
| **Restart Game** | `Mouse Click` (after Game Over) |

---

## 🎨 Art & Design
As per the initial requirements, this project showcases:
- **Animated Character:** Original sprite sheet and animation controller.
- **Environment:** Custom background and obstacle sprites.
- **User Interface:** Original buttons and HUD design.

<div align="center">
  <img src="https://via.placeholder.com/600x300.png?text=Flappy+Bird+Gameplay+Screenshot" alt="Game Screenshot Placeholder">
  <p><i>Example of original environment and character design. (Used as reference when creating this game)</i></p>
</div>

---

## ⚖️ Development Criteria
The project is evaluated based on the following:
- **Originality (5pts):** All concepts, design, and art are originally created.
- **Artistry & Creativity (5pts):** High level of artistic skill in character and environment design.
- **Level Design (5pts):** Clear narrative-based mechanics and complete gameplay loop.
- **Completeness (5pts):** All functional requirements (movement, scoring, collisions) are present.

---

## 📂 Project Structure
```text
Assets/
├── Animations/       # Character and UI animations
├── Audio/            # Sound effects and music
├── Prefabs/          # Obstacles and UI elements
├── Scenes/           # MainMenu, GameScene
├── Scripts/          # C# PlayerController, Spawner, GameManager
└── Sprites/          # Original character and environment art
```

---

> **Note:** All files should be saved using the format: `CourseProject`.

