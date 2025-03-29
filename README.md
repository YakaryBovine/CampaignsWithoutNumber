# Campaigns Without Number
A character sheet management system compatible with Worlds Without Number by Kevin Crawford. The intent is to add support for Stars Without Number, Ashes Without Number, and potentially other cross-compatible systems from Sine Nomine.

## Local development
### Prerequisites
- .NET 8 SDK
- Visual Studio or Jetbrains Rider
- Docker Desktop

### How to run
1. Checkout this repository via git
2. In the `devenv/infra` repository, copy the provided `.env.example` file, rename it to `.env`, and replace any credentials with secure, unique passwords
3. In the same directory, execute `docker compose up -d` to spin up SqlServer and create the database
4. Run the `CampaignsWithoutNumber.Web` project from Visual Studio or Jetbrains Rider