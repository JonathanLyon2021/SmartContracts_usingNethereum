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
    var provider = "Infura node provider goes here!!!";
      var contractAddress = "0xD614a73f2A5e18A74B70F8a1d1c9E6881Fe7d04e, probably be the deployed contract address";
    var abi = "abi of deployed contract goes here";
      var privateKey = "Private Key goes here";
    
    ContractService contractService = new ContractService(provider, contractAddress, abi, privateKey);
}

