Layer Vs Tiers

When there is just a logical separation in your application, we can term it as layers or N Layers. In cases where there is both a physical 
and logical separation of concerns, it is often referred to as n-tiered application where n is the number of separations. 3 is the most common 
value of N. In this article, we will deal with Layered Architecture.This layering can help in the separation of concerns, subdividing the 
solution into smaller units so that each unit is responsible for a specific task and also takes advantage of abstraction. For mid to larger 
scaled projects where multiple teams work, layering has very obvious advantages up its sleeves. It lets a specific team or individual work 
on a particular layer without disturbing the integrity of the others. It makes it much easier to track changes using source control.
Also, It just makes your entire solution look clean. 


============================================================================================================================================================


Brief Overview of N-Layer Architecture

Let’s look at one of the most popular Architecture in ASP.NET Core Applications. Here is a simple diagrammatic representation of a variation of the 
N-Layer Architecture. The presentation Layer usually holds the Part that the User can interact with, i.e, WebApi, MVC, Webforms, and so on. Business 
Logic is probably the most important part of this entire setup. It holds all the logic related to the Business requirements. Now, every application 
ideally has its own dedicated Database. In order to access the Database, we introduce a Data Access Layer. This layer usually holds ORMs for ASP.NET 
to fetch/write to the database.

Disadvantages of N-Layer Architecture:

To clearly understand the advantages of Onion Architecture in ASP.NET Core Applications, we will need to study the issues with N Layer Architecture. 
It is one of the most commonly used Solution Architectures amongst .NET developers.
Instead of building a highly decoupled structure, we often end up with several layers that are depending on each other. This is something really bad 
in building scalable applications and may pose issues with the growth of the codebase. To keep it clear, in the above diagram we can see that the 
presentation layer depends on the logics layer, which in turn depends on the data access and so on.
Thus, we would be creating a bunch of unnecessary couplings. Is it really needed? In most cases, the UI (presentation) layer would be coupled to 
the Data Access Layers as well. This would defeat the purpose of having clean architecture, yeah?
In N Layer Architecture, the Database is usually the Core of the Entire Application, i.e It is the only layer that doesn’t have to depend on 
anything else. Any small change in the Business Logics layer or Data access layer may prove dangerous to the integrity of the entire application.


============================================================================================================================================================


Getting Started with Onion Architecture

The Onion architecture, introduced by Jeffrey Palermo, overcomes the issues of layered architecture with great ease. With Onion Architecture, the 
game-changer is that the Domain Layer (Entities and Validation Rules that are common to the business case ) is at the Core of the Entire Application. 
This means higher flexibility and lesser coupling. In this approach, we can see that all the Layers are dependent only on the Core Layers.
Layers:
	1) Domain and Application Layer will be at the center of the design. We can refer to these layers as the Core Layers. These layers 
	will not depend on any other layers. Domain Layer usually contains enterprise logic and entities. Application Layer would have Interfaces and 
	types. The main difference is that The Domain Layer will have the types that are common to the entire enterprise, hence can be shared 
	across other solutions as well. But the Application Layer has Application-specific types and interfaces. Understand? As mentioned 
	earlier, the Core Layers will never depend on any other layer. Therefore what we do is that we create interfaces in the Application 
	Layer and these interfaces get implemented in the external layers. This is also known as DIP or Dependency Inversion Principle.
	For example, If your application want’s to send a mail, We define an IMailService in the Application Layer and Implement it outside the 
	Core Layers. Using DIP, it is easily possible to switch the implementations. This helps build scalable applications.
	2) The presentation layer is where you would Ideally want to put the Project that the User can Access. This can be a WebApi, Mvc Project, etc.
	3) The infrastructure layer is a bit more tricky. It is where you would want to add your Infrastructure. Infrastructure can be anything. 
	Maybe an Entity Framework Core Layer for Accessing the DB, a Layer specifically made to generate JWT Tokens for Authentication or even 
	a Hangfire Layer. You will understand more when we start Implementing Onion Architecture in ASP.NET Core WebApi Project.


============================================================================================================================================================


Advantages of Onion Architecture in ASP.NET Core:
	- Highly Testable – Since the Core has no dependencies on anything else, writing automated tests are flexible
	- Database Independent – Since we have a clean separation of data access, it is quite easy to switch between different database providers.
	- Switchable UI Layer (Presentation) – Since we are keeping all the crucial logic away from the presentation layer, 
	it is quite easy to switch to another tech – including Blazor.
	- Much Cleaner Codebase with well-structured Projects for better understanding with teams.