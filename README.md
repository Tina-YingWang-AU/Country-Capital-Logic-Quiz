# Interactive Country Capital Quiz (C#)

🌟 **Project Overview**

Developed during my Certificate IV in Information Technology at TAFE NSW, this project focuses on **Linear Data Structures** and **User Session State Management**. 

It is a professional console-based application designed to demonstrate data retrieval from multi-dimensional arrays. The core design philosophy is **Defensive Programming**, ensuring the system handles unpredictable user inputs gracefully while maintaining stability.

🚀 **Functional Modules**

The application is structured into three logical components to ensure a seamless and "crash-proof" user experience.

### 1. Data Orchestration (2D Arrays)
* **Matrix Management**: Leverages a `string[,]` 2D array to manage country-capital pairings, ensuring efficient data mapping and retrieval.
* **Dynamic Indexing**: Maps user-friendly serial numbers to array indices, providing an intuitive interface for navigating the dataset.

### 2. Progress Tracking & State Logic
* **State Management**: Utilizes a boolean flag array (`isChosen`) to track user progress. This prevents duplicate questions and ensures each session follows a unique path.
* **Real-time Analytics**: Provides dynamic feedback by calculating "X out of Y" progress, keeping the user informed of their status.

### 3. Defensive Input Validation
* **Crash-Proof Execution**: Implemented `int.TryParse` within validation loops to handle non-numeric inputs or out-of-range values without system failure.
* **Input Normalization**: Sanitizes all string inputs using `.Trim().ToLower()` to ensure the grading logic is case-insensitive and user-friendly.

🧠 **Logic Behind the Screen**

🛡️ **Core Execution Workflow**
1.  **Initialization**: Sets up the geographical matrix and progress tracking flags.
2.  **Validation Loop**: Confirms user selection and cross-references the state to ensure the country hasn't been picked.
3.  **Grading Engine**: Compares sanitized user answers against the 2D array data.
4.  **Session Control**: Manages the retry and continuation logic based on user feedback.



📐 **Design & Methodology**
The project follows **SDLC (Software Development Life Cycle)** best practices by prioritizing robustness. By anticipating "invalid" user behavior—such as entering text where numbers are expected—the system uses a **Validation-First** approach to ensure continuous uptime.

📂 **System Architecture**
* **Language**: C#
* **Framework**: .NET Core
* **Data Structure**: Multi-dimensional Arrays (`string[,]`)

🚀 **Learning & Growth Path**
This project was instrumental in mastering:
* **Algorithmic Thinking**: Managing nested loops for complex session control.
* **Data Integrity**: Using parallel tracking (boolean arrays) to monitor data states.
* **Professional UI/UX**: Designing a console interface that provides clear, actionable feedback.

---
**Author**: Tina Ying Wang  
**Institution**: TAFE NSW
