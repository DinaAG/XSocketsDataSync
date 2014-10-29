## XSockets DataSync Sample

This sample shows how easy you can sync data between clients.
The clients can be anything talking TCP/IP, but in this case we just use browsers.

### Pre-Req

The sample was built using VS2013

### Features

Lets you write a list of fruits that will be instantly synced between all clients.
All data is stored in memory so that the clients will get data when connecting.

You can Create, Update, Delete objects and they will be synced instantly.

### Code of interest

All code that may be of interest is in the XSockets folder in the root and in the file Views\Home\Index.cshtml
There are comments, but the code is pretty straight forward.

### Improvements
One idea would be to lock objects for other clients when editing etc. It would not take much to do, but as of right now we keep it simple.

Regards
Team XSockets.NET


