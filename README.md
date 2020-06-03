# Restaurant_with_online_orders

In C #, WPF and Microsoft SQL Server I created an application through which a restaurant can sell to customers online the dishes and products existing in the restaurant (this application is made in Romanian):

     For this application I initially created the restaurant database in Microsoft SQL Server. My database is a normalized database in Normal Form 3. There are no repetitions or many to many relationships in it. Where the relationship should be many to many we have created a link table.
     
     This database called Restaurant contains 12 tables / entities. From these tables we can find the dishes, menus in the restaurant. Each dish and menu belongs to a category, they contain allergens and an image with the dish. The customer accounts and their orders are also saved in the database.
     
     The application can be used by 3 types of users:
     
• those without an account

• those who have a client account

• those who have an employee account

     The user who does not have an account can create one, can log in, can see the restaurant menu or can do some searches in the menu.
     
     The user who has an account can place orders from the menu, can benefit from certain order bonuses, can see all his orders, and orders that he has not yet received can be canceled.
     
      The user who logs in as an employee has the possibility to add to the restaurant menu, he can change something from the menu or he can even delete from the menu. The employee can also see all the orders sorted in ascending order after the date of the order, he can change the status of an order (from registered to ready for delivery or canceled). He can also see the dishes approaching their completion in the restaurant.

![image](https://user-images.githubusercontent.com/58684695/83637552-7f7dcf00-a5b0-11ea-9dc3-ba2de5b9bd2b.png)
