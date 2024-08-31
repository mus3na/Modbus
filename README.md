# Modbus Reader POC

## Overview
Modbus Reader is a proof of concept (POC) developed using VB.NET and Visual Studio 2022. This project demonstrates how to read holding registers and input registers from any Modbus TCP capable equipment, such as solar PV inverters, without the need for additional dependencies.

This POC is intended primarily for educational purposes, aiming to provide students, educators, and hobbyists with a practical example of interfacing with industrial equipment using the Modbus protocol.

## Features
- **Read Holding Registers**: Retrieves values from specific registers of Modbus-enabled devices.
- **Read Input Registers**: Accesses read-only registers that typically contain dynamic data reflecting the device's operation.
- **Simple Interface**: A user-friendly interface that allows for easy interaction with the Modbus server.
- **No External Dependencies**: Runs independently with no need for external libraries, making it easy to deploy and use.

## Getting Started

### Prerequisites
- Microsoft Visual Studio 2022
- Basic understanding of the Modbus protocol and .NET programming

### Setup and Installation
1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/ModbusReader.git

2. **Open the solution in Visual Studio:**
   - Open the solution in Visual Studio:
   - Open the ModbusReader.sln file.

3. **Build the project:**
   - Ensure the solution configuration is set to Debug or Release.
   - Build the solution to resolve dependencies and prepare the executable.

## Usage

1. **Configure Connection Parameters:**
   - Configure Connection Parameters
   - Enter the device ID and specify the register address you wish to read

2.  **Reading Data:**
   - Choose between holding registers or input registers
   - Click the "Read" button to fetch the data from the device
 
 
 
![image](https://github.com/user-attachments/assets/75634f24-9431-4dfe-9aa6-33857c9a9949)
