# SmartContracts_usingNethereum
This is Exercise 14 from MI4 in Kingsland Universities Blockchain Developer Program

# Overview 
In this exercise, we will use Nethereum .NET integration library for Ethereum, simplifying the access and smart
contract interaction with Ethereum nodes. The exercise will show how to interact with an already deployed contract
on the Ethereum Goerli Testnet.

# Goals
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

# 2. Implementing the Smart Contract
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
If you do not have Ropsten test ETH, use the faucet: https://faucet.egorfine.com/
Copy the contract’s ABI by compiling the contract and clicking on the ‘ABI’ button below the Compilation Details.
You may not be able to copy the ABI directly in Visual Studio because the ABI is a JSON Object.
You have to escape all string characters (“) by prepending a backslash (\”).

## Hint:

Use the editor’s CTRL + H feature to quickly replace these occurrences. Be careful not to replace the quotes in other
parts of your program.
Then, deploy the contract using Injected Web3 while taking note of the address, copy those values in your C# code.
Because the contract owner can only add facts to this contract, export and copy the private key of the account that
deployed the contract. Don’t forget to prepend 0x to the private key.
Putting it all together, along with an instance of ContractService.

# 3. Smart Contract Interaction: Writing to the Smart Contract
Return to the ContractService class. Create a method which takes a string as an argument (a fact) and adds it to the
contract. We will send an asynchronous transaction - method.SendTransactionAsync(from, gas, value,
functionInput) and will not wait to be mined, just get the transaction hash.
In the main function, call the method.
Then, press Start.
A terminal will launch and will contain the transaction hash.
Check the transaction hash in Ropsten Etherscan to confirm if the transaction has succeeded.
Try adding a fact using another private key as an account. Hypothesize on what could happen and test it.

# 4. Smart Contract Interaction: Reading from the Smart Contract
When reading from a Smart Contract, no wallets or private keys are needed.
In the ContractService class, create a method which gets a fact by a given index and returns a string with the fact.
Get the method of the contract and then make an asynchronous call with the index as parameter, which will return
Task<string> and get the result.
Run the program.
Then finally, create a method, which gets how many facts are stored in the contract.
Run the program again...
  
## Congratulations! You've completed the exercise!
