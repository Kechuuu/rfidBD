# RFID Access System with MySQL Database

This project, `rfidBD`, is a system for managing access control using RFID cards and a MySQL database. Below are the instructions and details to get started.

## Features
- Manage access control using RFID cards
- Store and retrieve user data from a MySQL database
- User-friendly interface for easy operation

## Preview

### Login 

Here is a preview of the main interface of the application:

![login](https://github.com/Kechuuu/rfidBD/assets/117384007/9ced11dd-0225-4906-8730-ea53423443a1)

### Main

Here is the main interface of the application:

![image](https://github.com/Kechuuu/rfidBD/assets/117384007/b1f0f9f7-48da-4440-a4b3-5a038877fbb6)


### Selecting the Port 

In this section, you can select the port :

![image](https://github.com/Kechuuu/rfidBD/assets/117384007/f5de5ae7-a1b3-4da9-9d9e-f584f1079ab6)

### Using the Get and Set Buttons

Use the "Get" button to retrieve data from the RFID modules, and the "Set" button to send configurations to them:

![get-set](https://github.com/Kechuuu/EBYTE-NAS/assets/117384007/247a40f1-fb56-4852-90e1-b727018d0cda)

## Installation

To install and set up the system, follow these steps:

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/yourusername/rfidBD.git
    ```

2. **Navigate to the Project Directory:**

    ```bash
    cd rfidBD
    ```

3. **Install Dependencies:**

    ```bash
    npm install
    ```

4. **Set Up the MySQL Database:**

    - Create a new MySQL database.
    - Import the provided SQL script to set up the necessary tables and data.

5. **Configure Database Connection:**

    - Update the database connection settings in the configuration file to match your MySQL setup.

6. **Run the Application:**

    ```bash
    npm start
    ```

## Usage

Once the application is running, follow these steps to use the RFID access system:

1. Connect your RFID reader to the computer.
2. Open the application in your browser.
3. Follow the on-screen instructions to manage access control using RFID cards.

## Contributing

We welcome contributions! Please read our [Contributing Guide](CONTRIBUTING.md) to get started.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions or support, please open an issue or contact us at support@rfidbd.com.
