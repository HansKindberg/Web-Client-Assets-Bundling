# Web-Client-Assets-Bundling

Bundling client-assets for a web-application. Using gulp and rollup.

This is a solution for showing one way to handle client-assets for a web-application. That is:
- One bundled css-file (unminified/minified)
- One svg-sprite
- One bundled javascript-file (unminified/minified)

It is handled with npm, gulp, rollup and the "Task Runner Explorer".

The solution is a razor-pages-application, with some diagnostics pages. But that is not important. The important files and folders are:
- wwwroot
- Scripts
- Style
- gulpfile.js
- package.json
- tsconfig.json

Initially install all npm-packages by using any of the following:
- the install-task (package.json) in "Task Runner Explorer"
- right-clicking the package.json -> Restore Packages

Make changes to any of the following:
- Scripts/Site.ts
- Style/Icons (add an svg)
- Style/Images (add an image)
- Style/Site.scss

then run the "default" task in the "Task Runner Explorer" and you get the result under the wwwroot-folder.

## 1 GitHub workflows

This repository contains workflows:

- [Azure-Deploy.yml](/.github/workflows/Azure-Deploy.yml) - sets up a site in Azure
- [Docker-Deploy.yml](/.github/workflows/Docker-Deploy.yml) - deploys an image to Docker hub

The workflows uses secrets.

### 1.1 Secrets

#### 1.1.1 AZURE_CREDENTIALS

You need an Azure service principal to setup the credentials. If you not already have one, that you can use, you need to create one. A service principal ends up as an "App registration" in your Azure Active Directory. You can run commands with the **Cloud Shell** [>_] at https://portal.azure.com/.

	az ad sp create-for-rbac --name "{sp-name}" --role "Contributor" --sdk-auth

Response:

	{
	  "clientId": "{guid}",
	  "clientSecret": "{secret}",
	  "subscriptionId": "{guid}",
	  "tenantId": "{guid}",
	  "activeDirectoryEndpointUrl": "https://login.microsoftonline.com",
	  "resourceManagerEndpointUrl": "https://management.azure.com/",
	  "activeDirectoryGraphResourceId": "https://graph.windows.net/",
	  "sqlManagementEndpointUrl": "https://management.core.windows.net:8443/",
	  "galleryEndpointUrl": "https://gallery.azure.com/",
	  "managementEndpointUrl": "https://management.core.windows.net/"
	}

The first four are the ones you want. The value to set in your secret is:

	{"clientId":"{guid}","clientSecret":"{secret}","subscriptionId":"{guid}","tenantId":"{guid}"}

Links:
- https://docs.microsoft.com/en-us/cli/azure/ad/sp
- https://docs.microsoft.com/en-us/cli/azure/ad/sp#az_ad_sp_create_for_rbac
- https://github.com/marketplace/actions/azure-login#configure-deployment-credentials
- https://github.com/Azure/login

#### 1.1.2 AZURE_RESOURCE_GROUP_LOCATION

The location for the resource-group, eg. westeurope. List of available locations:
- https://azureprice.net/region

#### 1.1.3 AZURE_RESOURCE_GROUP_NAME

The name of the resource-group.

#### 1.1.4 DOCKER_PASSWORD

Your https://hub.docker.com/ access token.

#### 1.1.5 DOCKER_USERNAME

Your https://hub.docker.com/ username.