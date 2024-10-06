# **ZahlMeister** 🏦 💻 
![GitHub release (latest by date)](https://img.shields.io/github/v/release/ailynux/ZahlMeister?color=blue&style=for-the-badge)
![GitHub last commit](https://img.shields.io/github/last-commit/ailynux/ZahlMeister?color=green&style=for-the-badge)
![GitHub issues](https://img.shields.io/github/issues/ailynux/ZahlMeister?color=red&style=for-the-badge)
![GitHub pull requests](https://img.shields.io/github/issues-pr/ailynux/ZahlMeister?color=yellow&style=for-the-badge)
![GitHub stars](https://img.shields.io/github/stars/ailynux/ZahlMeister?color=ff69b4&style=for-the-badge)
![GitHub license](https://img.shields.io/github/license/ailynux/ZahlMeister?style=for-the-badge)

![Azure](https://img.shields.io/badge/Deployed%20on-Azure-blue?style=for-the-badge&logo=azuredevops)
![Tech Stack](https://img.shields.io/badge/stack-C%23%2C%20React%2C%20TypeScript%2C%20Azure-brightgreen?style=for-the-badge&logo=react)

**ZahlMeister** is a **payment processing monitor** designed to streamline and automate transaction management. By leveraging **Dapper**, **Selenium**, **C#**, and **Azure**, ZahlMeister simplifies the process of pulling payment records from databases and automates key tasks such as logging into payment systems, checking payment statuses, and generating reports. 

---

## 🚀 **Features**
- 🔄 **Automated Payment Tracking**: Automate login to payment systems and check payment statuses with **Selenium**.
- 💾 **Efficient Database Access**: Use **Dapper** to pull payment transactions and user records.
- 📊 **Report Generation**: Automatically generate reports on payment statuses and transaction histories.
- ☁️ **Azure Integration**: Fully cloud-deployed for scalability and reliability.

---

## 🛠️ **Tech Stack**
- **Back-end**: ASP.NET Core (C#), Dapper
- **Front-end**: React, TypeScript
- **Automation**: Selenium for web task automation
- **Database**: Azure SQL
- **Deployment**: Azure App Services, Azure Functions

---

## 📥 **Installation Guide**

### **Backend (ASP.NET Core)**
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/ZahlMeister.git
    cd ZahlMeister/backend
    ```
2. Install dependencies:
    ```bash
    dotnet restore
    dotnet run
    ```

### **Frontend (React + TypeScript)**
1. Navigate to the `client` folder:
    ```bash
    cd ../client
    ```
2. Install dependencies and run the app:
    ```bash
    npm install
    npm start
    ```

---

## 🧪 **Testing**

- **Unit Testing**: Implement tests for the back-end API using **xUnit** or **NUnit**.
- **UI Testing**: Write tests for the front-end using **Jest** and **React Testing Library**.
- **End-to-End Testing**: Test the entire workflow (from data pull to report generation) using Selenium and integration tests.

---

## 🛡️ **Security**
- **Authentication**: Use **Azure Active Directory** for secure login and user management.
- **Data Encryption**: Ensure all sensitive payment data is encrypted in the database and during transmission (using HTTPS).

---

## 🤝 **Contributing**

We welcome contributions! To contribute to ZahlMeister, follow these steps:

1. Fork the project.
2. Create a new feature branch: `git checkout -b feature/your-feature`.
3. Commit your changes: `git commit -m "Add new feature"`.
4. Push to the branch: `git push origin feature/your-feature`.
5. Open a pull request.

---

## 📝 **License**

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## 📧 **Contact**

For any questions, suggestions, or collaboration opportunities, feel free to reach out:

- 💼 LinkedIn: [Ailyn Diaz](https://www.linkedin.com/in/ailyndiaz01)

Let's connect and collaborate!

