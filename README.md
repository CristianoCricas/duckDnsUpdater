# duckDnsUpdater
A simple Win Client to update DuckDNS domain IP

## 1. Configuring the updater before Compile

##### 1.1. Open method "private void timer1_Tick" on "formAtualizaIP.cs"

##### 1.2. Put the values from your DuckDNS account on the variables:
```
string token = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx"; //token atual cadastrado
string domain = "domain"; //dominio configurado
```

## 2. Start and Stop App

##### 2.1. After configure, just START the project on Visual Studio or Build "AtualizaIPExternoDuckDNS.exe"

##### 2.2. When you try to CLOSE, it'll MINIMIZE to Taskbar. It's to force App to running in background, and check de IP every 5 minutes

##### 2.3. To STOP App:
- If you're running it from Visual Studio, just STOP DEBUGGING
- If you're running the App, use CTRL + ALT + DEL and **END TASK**


## 3. There still much improvements needed. 

##### It's just an initial version that I created to automate my DuckDNS IP update. Suggestions are welcome :wink:

