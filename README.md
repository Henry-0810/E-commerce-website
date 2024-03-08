# E-Commerce Website

## Project Overview
This project is an E-Commerce website built using ASP.NET for the backend, React for the frontend, and Azure SQL for the database. The website facilitates three main user roles: Admin, Vendor, and Buyer. It integrates Stripe as the payment gateway for secure transactions.

## Features

### User Roles
1. **Admin**: Admins have access to the administrative dashboard where they can manage users, products, orders, and other aspects of the system.
2. **Vendor**: Vendors can add, edit, and delete products they offer for sale. They can also view and manage their orders.
3. **Buyer**: Buyers can browse products, add them to the cart, proceed to checkout, and make payments.

### Stripe Integration
Stripe is integrated as the payment gateway to securely process payments for orders placed on the website. It ensures a smooth and secure transaction experience for buyers.

### Product Management
Vendors can manage their product listings, including adding new products, updating existing ones, and removing products that are no longer available.

### Order Management
Both vendors and admins have access to order management functionalities. They can view orders, update order statuses, and handle order-related tasks efficiently.

### Authentication and Authorization
The website implements authentication and authorization mechanisms to ensure secure access to different parts of the system based on user roles.

## Setup Instructions
To run the project locally, follow these steps:

1. **Clone the Repository**: Clone the project repository to your local machine.
2. **Backend Setup**:
   - Open the backend solution in Visual Studio.
   - Configure the Azure SQL database connection string in `appsettings.json`.
   - Run the database migrations to create the necessary tables.
   - Start the backend server.
3. **Frontend Setup**:
   - Navigate to the frontend directory.
   - Install dependencies using `npm install`.
   - Configure environment variables, including Stripe API keys.
   - Start the frontend server using `npm start`.
4. **Testing**:
   - Access the website through a web browser.
   - Create user accounts for different roles (Admin, Vendor, Buyer).
   - Test various features including product browsing, ordering, and payment processing.

## Additional Features to Consider
- **User Reviews and Ratings**: Allow buyers to leave reviews and ratings for products they've purchased.
- **Advanced Search and Filters**: Implement advanced search and filtering options to help buyers find products more easily.
- **Notifications**: Implement email or push notifications for order updates, promotions, and other relevant events.
- **Inventory Management**: Provide vendors with tools to manage their inventory, including tracking stock levels and receiving low-stock alerts.
- **Analytics Dashboard**: Create a dashboard for admins to monitor sales, site traffic, and other key metrics.
- **Multi-Language Support**: Make the website accessible to users from different regions by implementing multi-language support.
- **Responsive Design**: Ensure the website is optimized for various devices, including desktops, tablets, and smartphones.

## Contributors
- [Henry Pan]([https://github.com/Henry-0810])

## License
This project is licensed under the [MIT License](LICENSE).
