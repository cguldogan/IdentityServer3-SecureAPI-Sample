# IdentityServer3-SecureAPI-Sample
This app is to show how to secure your API using IdentityServer3

About Project 
Project has one controller and two methods. One of them has  [Authorize] attribute to control Authentication.

. First, you need to get token from your 
IdentityServer's token endpoint [http://yourserver/connect/token]

. Second you need to assign your token to Authorization header.(Dont forget to add Bearer keyword)

![Alt text](http://imgur.com/rGg4qX2.png "Controllers")

![Alt text](http://imgur.com/UWgTX3n.png "How to assign token")

How to get token sample
![Alt text](http://imgur.com/YDvfNN6.png "How to get token")
