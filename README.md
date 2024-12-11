
# Project Modules and Functional Requirements (ERP Software for E-commerce)

| **Number** | **Module**                        | **Functional Requirements**                                                                                                                                                                         |
|------------|------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 1          | **Inventory Management Module**   | **Inventory Management**: Track stock levels and update in real-time.<br>**Warehouse Management**: Manage multiple warehouses and their stock allocation.<br>**Supplier Management**: Store supplier details, assess performance, and manage contracts.<br>**Procurement Management**: Automate purchase requests, approvals, and orders. |
| 2          | **Sales & Customer Management Module** <br>(Overview of sales data) | **Order Management**: Create, modify, and track purchase and sales orders.<br>**Sales Quotation**: Generate and manage customer quotations.<br>**Invoicing and Billing**: Issue invoices, manage payments, and integrate tax calculations.<br>**Customer Management**: Maintain customer profiles, purchase history, and support tickets. |
| 3          | **Analytics and Reporting Module** | **User Roles and Permissions**: Define access levels for users.<br>**Reporting and Dashboards**: Generate business analytics reports.<br>**Shipping and Logistics**: Manage shipment tracking, carrier assignments, and delivery status.<br>**Notifications and Alerts**: Set up email/SMS notifications for key events.<br>**System Integration** (Optional): Integrate third-party APIs (e.g., payment gateways, CRM tools). |


# Team Members

1.  Soumik Deb Niloy 
2.  Shaownak Shahriar
3.  Debjoty Mitra

## Steps to Run the Project

### 1. Clone the Repository

Clone the project repository to your local machine:

```bash
git clone <repository-url>
```

Replace `<repository-url>` with the actual URL of your repository.

### 2. Navigate to the Project Directory

Move into the project directory:

```bash
cd <project-directory>
```

Replace `<project-directory>` with the folder name of the cloned repository.

### 3. Restore Dependencies

Restore the necessary NuGet packages:

```bash
dotnet restore
```

### 4. Build the Project

Build the project to ensure there are no compilation errors:

```bash
dotnet build
```

### 5. Run the Project

Run the project locally:

```bash
dotnet run
