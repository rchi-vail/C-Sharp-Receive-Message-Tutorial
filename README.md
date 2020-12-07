# C# - Receive a Message Tutorial

This project serves as a guide to help you build an application with FreeClimb. View this tutorial on [FreeClimb.com](https://docs.freeclimb.com/docs/how-to-receive-a-message#section-c). Specifically, the project will:

-Receive and respond to an incoming SMS message

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the Tutorial

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk
   ```
2. Configure environment variables.

| ENV VARIABLE | DESCRIPTION                                                                                                                              |
| ------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| ACCOUNT_ID   | Account ID which can be found under [API Keys](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard           |
| AUTH_TOKEN   | Authentication Token which can be found under [API Keys](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard |

3. Provide a value for the variable `from` in FreeClimbController.cs. `from` is a FreeClimb number that makes the call ([Incoming Numbers](https://www.freeclimb.com/dashboard/portal/numbers)).


## Runnning the Tutorial

1. Run the application using command:

   ```bash
   $ dotnet run
   ```

## Getting Help

If you are experiencing difficulties, [contact support](https://freeclimb.com/support).
