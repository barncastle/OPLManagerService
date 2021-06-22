# OPL Manager Service

.Net Standard 2.1 bindings for OPL Manager's web service used for retrieving game art and names.

Client instances are created using the `OPLManagerServiceSoapClient.GetApiInterfaceInstance()` method. Requests can be made either directly (blocking call) or asynchronously with results pushed through EventHandlers.

```c#
using var client = OPLManagerServiceSoapClient.GetApiInterfaceInstance();

// direct call
var gameName = client.GetGameNameById(GameType.PS2, "SLPM_675.05");

// async call
client.GetGameNameByIdCompleted += (sender, args) => Console.WriteLine(args.Result);
client.GetGameNameByIdAsync(GameType.PS2, "SLPM_675.05");
```

Everything should be self described but available endpoints are:

- `GetDesktopAppVersion`
- `ServiceStatus`
- `ArtSearchSingle`
- `ArtSearchBatch`
- `BatchArtShareCheck`
- `ArtUpload`
- `ReportArt`
- `GetGameNameById`

