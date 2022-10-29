using System;
  using Nethereum.Web3;
  using Nethereum.Contracts;
  using Nethereum.Web3.Accounts;
  using Nethereum.Hex.HexTypes;
  
class Program {
  class ContractService {
    private readonly Web3 web3;
    private readonly Contract contract;
    private readonly Account account;
    
    private static readonly HexBigInteger GAS = new HexBigInteger(4600000);
    
    public ContractService(string provider, string contractAddress, string abi, string privateKey)
    {
      this.account = new Account(privateKey, 3);
      this.web3 = new Web3(account, provider);
      this.contract = web3.ETH.GetContract(abi, contractAddress);
    }
  
    public string AddFact(string fact)
    {
      var addFactFunction = contract.GetFunction("add");
      var txHash = addFactFunction.SendTransactionAsync(account.Address, GAS, new HexBigInteger(0), fact)
        .ConfigureAwait(false)
        .GetAwaiter()
        .GetResult();
      return txHash;
    }
  }
  
  static void Main(string[] args)
    
  {
    var provider = ""https://goerli.infura.io/v3/08ca1c5dddd34508a9cba3a337ae801c";";
      var contractAddress = "0xe3836A461C0153A5Ea61eE794739e2b1d4763a1f";
    var abi = [
	{
		"inputs": [],
		"stateMutability": "nonpayable",
		"type": "constructor"
	},
	{
		"inputs": [
			{
				"internalType": "string",
				"name": "newFact",
				"type": "string"
			}
		],
		"name": "add",
		"outputs": [],
		"stateMutability": "nonpayable",
		"type": "function"
	},
	{
		"inputs": [],
		"name": "count",
		"outputs": [
			{
				"internalType": "uint256",
				"name": "",
				"type": "uint256"
			}
		],
		"stateMutability": "view",
		"type": "function"
	},
	{
		"inputs": [
			{
				"internalType": "uint256",
				"name": "index",
				"type": "uint256"
			}
		],
		"name": "getFact",
		"outputs": [
			{
				"internalType": "string",
				"name": "",
				"type": "string"
			}
		],
		"stateMutability": "view",
		"type": "function"
	}
];
      var privateKey = "Private Key goes here";
    
    ContractService contractService = new ContractService(provider, contractAddress, abi, privateKey);
    
    var fact = "The Times 03/Jan/2009 Chancellor on brink of second bailout for banks";
    System.Console.WriteLine($"Transaction Hash: {contractService.AddFact(fact)}");
    System.Console.WriteLine($"Press any key to Exit.....");
    System.Console.ReadLine();  
  }
}
