# RFID Access System with MySQL Database

This project, `rfidBD`, is a system for managing access control using RFID cards and a MySQL database. Below are the instructions and details to get started.

## Features
- Manage access control using RFID cards
- Store and retrieve user data from a MySQL database
- User-friendly interface for easy operation

## Preview

### Main Interface

Here is a preview of the main interface of the application:

![main](https://github.com/Kechuuu/EBYTE-NAS/assets/117384007/9de86482-bc48-4058-a702-e1f61cd3596c)

### Selecting the Port and RFID Module Version

In this section, you can select the port and the version of the RFID module you are using:

![port](https://github.com/Kechuuu/EBYTE-NAS/assets/117384007/684fcc6c-c92d-456a-b687-3a51696c78c1)

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
