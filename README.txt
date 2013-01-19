------------------
Installation Guide
------------------

Step 1: MYSQL
- add the following user: username:aic with password:aic2012
- insert the two mysql scripts sql_all.sql (creates the databases) and testdata.sql (provides testdata)



Step 2: Deploy the 3 Services from Stage 1 to the IIS

(It might be required to add the user IUSR with full access priviledges to the aic_stage1_properties)

- Open the IIS-Manager
- Right click on Default Web Site - Add Application
- Aliases should be the following: BillingService, AuthenticatorService, StatisticService
- The Path: they are located in the folder in I:\Workspace\aic_group2_topic1\AIC_Stage1)
- If the services are deployed successfully http://localhost/AuthenticatorService/AuthenticatorService.svc?wsdl for example should show the corresponding wsdl


This Setup can now be testet for example via the command line TestClient we created for stage 1: Just start 
the SentimentClient.exe located in \aic_group2_topic1\AIC_Stage1\SentimentClient\bin\Debug with admin privileges


Step 3: Deploy the bpel processes to ODE

We added the processes as *.zip files for easier deployment

- Use localhost if possible, else there would be changes required in the bpel wsdl's
- Visit http://localhost:8080/ode/deployment.html and upload the 3 zip files
- If everything was successful, there should be 6 active processes in the process view

Step 4: Deploy our website to Tomcat

- Add the war-file to your tomcat webapps folder
- Open <tomcat_config>/stage2_website/
- a Testuser with open bills would be "max" - username: max, password: 1234