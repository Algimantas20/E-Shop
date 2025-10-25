# E-Shop

## 🚀 Overview
E-Shop is a comprehensive e-commerce application built using C#. It provides a user-friendly interface for browsing, adding to cart, and purchasing products. The application is designed to be intuitive and efficient, making it suitable for both developers and end-users.

### Key Features
- **User Authentication**: Secure login and signup functionality.
- **Product Management**: Add, view, and manage products.
- **Shopping Cart**: Add and remove items from the cart.
- **Order Management**: Track and manage orders.
- **Admin Panel**: Manage users and products with administrative privileges.

### Who This Project Is For
- Developers looking to build an e-commerce application.
- Businesses needing a customizable e-commerce solution.
- Users who want to explore and purchase products easily.

## ✨ Features
- 🛍️ **Product Catalog**: Browse and search for products.
- 💸 **Shopping Cart**: Add and remove items from the cart.
- 📦 **Order Management**: Track and manage orders.
- 🔒 **User Authentication**: Secure login and signup.
- 🛠️ **Admin Panel**: Manage users and products.

## 🛠️ Tech Stack
- **Programming Language**: C#
- **Frameworks**: Windows Forms, Entity Framework
- **Database**: SQL Server
- **Tools**: Visual Studio, Git

## 📦 Installation

### Prerequisites
- .NET SDK 5.0 or later
- Visual Studio 2019 or later
- SQL Server

### Quick Start
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/E-Shop.git
    ```
2. Open the solution in Visual Studio.
3. Restore NuGet packages:
    ```bash
    dotnet restore
    ```
4. Build and run the application:
    ```bash
    dotnet run
    ```

### Advanced Usage
- **Configuration**: Modify the `app.config` file to change database connection settings.
- **API Documentation**: Refer to the API documentation for more advanced usage.

## 📁 Project Structure
```
E-Shop/
├── .gitignore
├── Program.cs
├── Classes/
│   ├── HashHelper.cs
│   ├── MessageHelper.cs
│   ├── Product.cs
│   ├── Session.cs
│   ├── User.cs
├── Components/
│   ├── A_Form.cs
│   ├── A-Button.cs
│   ├── A-DelayedButton.cs
│   ├── A-ItemWindow.cs
│   ├── A-Panel.cs
│   ├── A-PreviewButton.cs
│   ├── A-SidePanelButton.cs
│   ├── A-TextBox.cs
├── Database/
│   ├── E_Shop_DatabaseDataSet.cs
│   ├── E_Shop_DatabaseDataSet.Designer.cs
├── Forms/
│   ├── SidePanelForms/
│   │   ├── AddProducts_Form.cs
│   │   ├── OrderDatabase_Form.cs
│   │   ├── Shop_Form.cs
│   │   ├── UserPriviliges_Form.cs
│   │   ├── ViewCart_Form.cs
│   ├── SignIn_Form.cs
│   ├── SignUp_Form.cs
│   ├── Sub_Forms/
│   │   ├── PicturePreview_Form.cs
│   │   ├── Product_Form.cs
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs
│   ├── Settings.Designer.cs
└── README.md
```
