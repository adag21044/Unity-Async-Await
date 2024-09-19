# Unity Async-Await

This project demonstrates the implementation of the **Command Pattern** in Unity using **async/await** to handle input commands to move a cube along the X and Z axes. The project adheres to **SOLID principles**, especially focusing on the **Single Responsibility Principle (SRP)** and **Open/Closed Principle (OCP)**.

## Features
- **Async/Await Integration**: The commands are executed asynchronously with brief delays, mimicking complex operations like network requests or resource-heavy calculations.
- **Command Pattern**: Movement commands (forward, backward, left, right) are encapsulated in their respective classes, adhering to the Command design pattern.
- **Singleton Pattern**: The `PlayerMovementManager` is implemented as a Singleton to centralize movement logic.
- **Separation of Concerns**: Input handling and movement logic are clearly separated into different classes, following SOLID principles.
