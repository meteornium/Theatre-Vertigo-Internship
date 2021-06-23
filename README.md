# C# and .NET Live-Project

Collection of work completed through the C# and .NET Live Project. Completed 4 tasks within the span of two weeks, ranging from implementing code-first database creation to manipulating data displayed on screen depending on what type of "Rental" user had placed. 

## Task One: Formatting Address and Phone Number
The first task I completed was properly formatting the theatre's address and phone number at the bottom of the screen. Code was written in such a way to properly format any address and phone number given to it.

![image](https://user-images.githubusercontent.com/79771326/123161949-e4f36680-d424-11eb-8194-546d393dafb9.png)

## Task Two: Rental Class and MVC
The next task had me creating the Rental class in order to store rental information into a database, along with the MVC for the rentals. This allowed for rentals to be added to the database from the site and for the rentals in the database to be displayed on the index page.

Creating a Rental:
![image](https://user-images.githubusercontent.com/79771326/123162636-b32ecf80-d425-11eb-9fc8-51c6b7f09b9a.png)


Stored Rentals:
![image](https://user-images.githubusercontent.com/79771326/123162668-be81fb00-d425-11eb-8c41-01520528a2b1.png)


## Task Three: RentalEquipment and RentalRoom classes
Two additional classes were added onto the Rentals class, both inherit from Rentals and have unique properties that get added to the database.

RentalEquipment:
![image](https://user-images.githubusercontent.com/79771326/123162700-c8a3f980-d425-11eb-8b21-487a980ea1d2.png)

RentalRoom:
![image](https://user-images.githubusercontent.com/79771326/123162731-d22d6180-d425-11eb-9df6-ff26a2d27aa2.png)

## Task Four: Adding RentalEquipment and RentalRoom to Rental Creation
Created a dropdown that asks user if they are creating a Rental, RentalEquipment, or RentalRoom. The fields they are able to fill changes depending on which one, and the database stores the information that they fill out. When accessing the database from the site, Rentals only show Rentals fields, RentalEquipments only show Rental and RentalEquipment fields, and RentalRooms only show Rental and RentalRoom fields. 

Dropdown:
![image](https://user-images.githubusercontent.com/79771326/123162909-02750000-d426-11eb-8445-9fb8acef9fa5.png)

Rental Create and Edit screen:
![image](https://user-images.githubusercontent.com/79771326/123162786-e1141400-d425-11eb-9d73-02b42611ba05.png)
![image](https://user-images.githubusercontent.com/79771326/123162828-ef623000-d425-11eb-9e5c-b9b67bc7b718.png)

RentalEquipment Create and Edit screen:
![image](https://user-images.githubusercontent.com/79771326/123162968-0f91ef00-d426-11eb-9c7b-23a408562bf7.png)
![image](https://user-images.githubusercontent.com/79771326/123163008-1882c080-d426-11eb-8c15-72086c0a9986.png)

RentalRoom Create and Edit screen:
![image](https://user-images.githubusercontent.com/79771326/123163050-246e8280-d426-11eb-9ec1-8b64d6e412c3.png)
![image](https://user-images.githubusercontent.com/79771326/123163081-2d5f5400-d426-11eb-9ac4-1266b549efb2.png)

