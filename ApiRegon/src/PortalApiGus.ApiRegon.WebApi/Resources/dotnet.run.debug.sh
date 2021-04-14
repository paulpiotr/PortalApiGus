#!/bin/bash

echo "$PWD Run dotnet build"

if [[ ! -z $(tasklist | grep w3wp.exe | awk '{ print $2 }') ]]; then
    for pid in $(tasklist | grep w3wp.exe | awk '{ print $2 }')
    do
        echo "Kill process w3wp.exe $pid"
        taskkill //PID $pid //F
    done
fi

#echo "Stop WebApplicationUnimotWork"
#/C/Windows/System32/inetsrv/appcmd.exe stop site /site.name:WebApplicationUnimotWork

cd /D/Praca/NetCoreDev/PortalApiGus/ApiRegon/src/PortalApiGus.ApiRegon.WebApi

echo "dotnet clean PortalApiGus.ApiRegon.WebApi.csproj -c Debug"
dotnet clean PortalApiGus.ApiRegon.WebApi.csproj -c Debug

echo "dotnet dev-certs https --trust"
dotnet dev-certs https --trust

echo "dotnet run -p PortalApiGus.ApiRegon.WebApi.csproj -c Debug -f net5.0"
dotnet run -p PortalApiGus.ApiRegon.WebApi.csproj -c Debug -f net5.0

#echo "Start WebApplicationUnimotWork"
#/C/Windows/System32/inetsrv/appcmd.exe start site /site.name:WebApplicationUnimotWork
