1. Uses Owin middleware modules with ASPnet Core and aspnet pipeline
2. Uses Kesterl as web server and IIS as reverse proxy
modify the web.config file to use following
<configuration>
  <system.webServer>
  	<directoryBrowse enabled="true" />
    <handlers>
      <add name="aspNetCore" path="*" verb="*"
       modules="AspNetCoreModule" resourceType="Unspecified"/>
    </handlers>
    <aspNetCore processPath="dotnet" arguments=".\AspNetCoreOwin.dll"
       stdoutLogEnabled="false" forwardWindowsAuthToken="false"/>
  </system.webServer>
</configuration> 

3. created using dotnet new -t web (command) [ Project.json]
4. for Kesterl web server microsoft.netcore.app 1.0.0 frame work is reqired