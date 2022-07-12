# Postman Collection Manager
This is a collection of DTO objects that represent an exported [Postman](https://www.postman.com/) Collection. It has been tested by:
1. Using Postman to read the Swagger [PetStore OAS document](https://petstore.swagger.io/) and convert it into a postman collection.
1. Exporting the collection to a json file (see the Swagger Petstore.postman_collection.json file).
1. Running the console app in this repo, which loads the json into the DTOs, then saves it out again.
1. Comparing the output.

The auto-generated documentation for this project can be found [here](https://github.com/testandattack/PostmanCollection/blob/master/PostmanManager/MarkDown/PostmanManager.md). Thanks to Paillat Laszlo for his [Default Documentation](https://github.com/Doraku/DefaultDocumentation) project.
