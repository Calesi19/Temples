
![Temples API Banner](/docs/banner.png)


# LDS Temples API

## Overview
This repository contains the LDS Temples API, a comprehensive resource for accessing information about Latter-day Saint (LDS) temples. Designed with efficiency and ease of use in mind, it offers detailed data about each temple, including location, history, and other relevant details.

## Features

Comprehensive Temple Data: Access detailed information about each LDS temple.
Search and Filter: Easily search for temples by various criteria.
Regular Updates: The database is regularly updated with the latest information.

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

## Prerequisites
* Docker
* Git (optional, for cloning the repository)

## Installing
Clone the repository (if using Git):

```
git clone https://github.com/[your-username]/lds-temples-api.git
```
Navigate to the project directory:

```
cd lds-temples-api
```
Build the Docker container:

```
docker build -t lds-temples-api .
```
Run the container:


```
docker run -p 4000:4000 lds-temples-api
```
The API should now be running on localhost:4000.

## Usage
Detailed API documentation can be found here.

## Example Requests
Get a list of temples:
```
curl http://localhost:4000/temples
```
Get information about a specific temple:
```
curl http://localhost:4000/temples/{templeId}
```

## License
This project is licensed under the MIT License - see the LICENSE.md file for details

