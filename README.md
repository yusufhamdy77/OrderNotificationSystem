# 📩 Order Notification System

## 📌 Project Overview
A simple C# console application that demonstrates the Observer Pattern using Events and Delegates.  
The system simulates placing an order and notifying different services (Email & SMS).

---

## 🧠 Features
- Place an order
- Notify subscribers when an order is placed
- Send Email notification
- Send SMS notification

---

## 📂 Project Structure
OrderNotificationSystem
├── Program.cs
├── Models
│ └── Order.cs
├── Services
│ ├── OrderService.cs
│ ├── EmailService.cs
│ └── SMSService.cs

---

## ⚙️ Technologies Used
- C#
- .NET Console Application
- Object-Oriented Programming (OOP)

---

## 🧠 Concepts Used

### 1. Delegate
A custom delegate is defined inside `OrderService` to define the method signature for event handling.

public delegate void OrderPlacedEventHandler(Order order);

2. Event

An event is used to notify subscribers when an order is placed.
The event is triggered inside the PlaceOrder method:
OrderDone?.Invoke(order);
3. Observer Pattern

This project implements the Observer Pattern:

Publisher: OrderService
Subscribers: EmailService, SMSService

When an order is placed, all subscribers are notified automatically


How It Works
An Order object is created in Program.cs
Services subscribe to the event:
EmailService
SMSService
PlaceOrder() is called
Event is triggered
All subscribed services are notified 


Key Learning Outcomes
Understanding Delegates in C#
Working with Events
Implementing Observer Pattern
Separating responsibilities between classes
Basic event-driven programming
