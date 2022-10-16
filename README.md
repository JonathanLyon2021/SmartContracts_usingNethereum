# SmartContracts_usingNethereum
This is Exercise 14 from MI4 in Kingsland Universities Blockchain Developer Program

# Overview 
In this exercise, we will use Nethereum .NET integration library for Ethereum, simplifying the access and smart
contract interaction with Ethereum nodes. The exercise will show how to interact with an already deployed contract
on the Ethereum Goerli Testnet.

# Goal
• Deploy and interact with a Smart Contract using Nethereum.

# Prerequisites
• Visual Studio Community 2019. <br>
• .NET Framework 4.7.2 <br>
• Nethereum.Contracts v4.5.0 <br>
• Nethereum.Web3 v4.5.0 <br>
You may download it here: https://visualstudio.microsoft.com/vs/ <br>

Then, just continue with the installation steps.
You may find that the setup will prompt you for some miscellaneous plugins. It’s important that you select
.NET Desktop Development. As for others, you may select if you fancy them.
Proceed with the installation.


# 1. Setup the Development Environment
Open the Visual Studio 2022 Software. Then, create a C# .NET Core Console Application.

Continue to configure your project specifying the name, location, solution name, and framework.
In this exercises we will use 
__.NET Framework 4.7.2__

Then go to Tools -> NuGet Package Manager -> Manager NuGet Packages for Solution. <br>

Navigate to Browse and install the following NuGetPackages. <br>
Accept any prompts that will show up. <br>
After successful installation, you’ll see these packages in the installed tab, along with other dependencies. <br>

# 2. Implementing the Contract
Import the following namespaces in order to use Nethereum’s Web3 libraries.

Inside the Program class, create a class called ContractService, which will be the connection to the Goerli Testnet.
Create 3 read-only private properties for the Web3, the Contract and for an Account, which will be the wallet.

Then, create a constructor, which takes 4 parameters: provider of the node, contract address, contract ABI, and a
private key for an account/wallet. Putting it all together.

We will need HTTPProvider in order to create our connection to the Ropsten Testnet using Infura.io.
Now, let’s get the necessary Infura.io provider. Go to https://infura.io/ and click [Get started for free]. You may also
choose to login if you have registered before.

When you are logged in, select on a project (create one first if you already don’t have a project) and take note of the
endpoint URL found in the highlighted section.

Add a Main() entry point just below the ContractService class and add the provider variable.

In order to get a contract instance of an already deployed contract, we will need its address and application binary
interface. For exercise’s purpose, deploy a simple contract storing an array of facts through Remix IDE using
MetaMask Goerli as a provider.

