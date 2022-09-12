# CMPG-323-Project-2---33768080
# This is my repository for Project 2

# Project Description:
In this project, I created a CRUD RESTful API that connects to a database storing IoT device data. For each resource the API contains a get, post, put and delete method. The RESTful API architecture has several endpoints called over HTTP, enabling it to update a database.

# Branching:
I used 3 branches for my project. Main, Adding_Security and Adding_Controllers. I used the Main branch as my stable and fully functional version of the project. The Adding_Securtity branch was used to implement security and was then merged into Main after it was implemented successfully. The Adding_Controllers branch was used to implement controllers and was then merged into Main after it was implemented successfully. The Main branch was used for implementing most of the project, where certain parts are dependent on other.

# End Points:
## Authenticate:
POST/api/Authenticate/login (logs in a user)

POST/api/Authenticate/register (registers a user)

POST/api/Authenticate/register-admin (registers an admin)

## Categories:
GET/api/Categories - (Retrieves all categories from database)

POST/api/Categories - (Creates a new category in the database)

GET/api/Categories/{id} - (Retrieves one category from database according to its ID)

PUT/api/Categories/{id} - (Updates an existing category)

DELETE/api/Categories/{id} - (Deletes an existing category acording to its ID)


## Devices:
GET/api/Devices - (Retrieves all devices from database)

POST/api/Devices - (Creates a new device in the database)

GET/api/Devices/{id} - (Retrieves one device from database according to its ID)

PUT/api/Devices/{id} - (Updates an existing device)

DELETE/api/Devices/{id} - (Deletes an existing device according to its ID)

## Zones:
GET/api/Zones - (Retrieves all zones from database)

POST/api/Zones - (Creates a new zone in the database)

GET/api/Zones/{id} - (Retrieves one zone from database according to its ID)

PUT/api/Zones/{id} - (Updates an existing zone)

DELETE/api/Zones/{id} - (Deletes an existing zone according to its ID)

# API Management Service
![image](https://user-images.githubusercontent.com/90321243/189648788-99d81a3f-92d1-4ed4-b8da-4e36f9b9ad38.png)
![image](https://user-images.githubusercontent.com/90321243/189648875-8efd709c-118b-4569-96d3-478d155cc2af.png)
