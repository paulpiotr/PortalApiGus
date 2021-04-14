#! bash

dotnet ef migrations remove --force
dotnet ef migrations add 3
dotnet ef migrations script > script.sql