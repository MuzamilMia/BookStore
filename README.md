Project: BookStore
Description
A web application for online book sales with a comprehensive user management system, role-based access control, and book catalog management. The service provides an intuitive interface for both customers and administrators, facilitating a seamless book purchasing process and efficient inventory management.
Functional Requirements
Users and Roles
Anonymous User (Visitor)
•	Can browse the book catalog without purchasing capability
•	Can search books by title, author, genre, or ISBN
•	Can view detailed book information including descriptions and prices
•	Can register to gain full access to platform features
Administrator
•	CREATE: Can add new books to the catalog with complete details
•	READ: Can view all orders, customer data, and sales analytics
•	UPDATE: Can edit book information, prices, stock quantities, and categories
•	DELETE: Can remove books from catalog and manage user accounts
•	Can manage book categories, genres, and author information
•	Can manage inventory levels and receive low-stock alerts
Book Catalog Features
•	Display available books with covers, prices, descriptions, and ratings
•	Advanced filtering by genre, author, price range, publication date, and rating
•	Search functionality across title, author, ISBN, and description fields
Authentication & Authorization System
•	User registration with email verification
•	Secure login/logout functionality
•	Password recovery and reset mechanisms
Deployment Requirements
•	PostgreSQL database server
•	.NET Core runtime environment
•	Email service for notifications
License
MIT License
