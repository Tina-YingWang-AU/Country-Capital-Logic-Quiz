# Country Capital Logic Quiz

An interactive C# console application designed to test geographical knowledge through structured logic. This project demonstrates robust user-input handling, state management, and clear control flow.

## 📌 Project Overview
The application challenges users to guess the capitals of various countries. It focuses on creating a "crash-proof" user experience through rigorous input validation and provides real-time progress tracking.

## 🚀 Technical Features
* **Defensive Programming**: Utilized `int.TryParse` to validate user input, ensuring the system handles non-numeric data gracefully without crashing.
* **State Management**: Implemented a boolean tracking array (`isChosen`) to monitor user progress and prevent the system from repeating questions.
* **Data Normalization**: Applied `.Trim().ToLower()` to user inputs to ensure the grading logic is user-friendly and case-insensitive.
* **Dynamic Feedback**: Features a multi-layered nested loop system to provide conditional feedback based on user accuracy and choices.

## 🛠️ Technology Stack
* **Language**: C#
* **Environment**: .NET Core / Visual Studio
* **Core Concepts**: 2D Arrays, Logical Control Flows, Input Sanitization.

---
**Author**: Tina Ying Wang  
**Institution**: TAFE NSW
