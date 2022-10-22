//SPDX-License-Identifier: MIT
pragma solidity >= 0.7.0 < 0.8.14;

contract ArrayOfFacts {
    string[] private facts;
    address private contractOwner;
     
     constructor() {
        contractOwner = msg.sender;
    }

     modifier onlyOwner() {
        require(msg.sender == contractOwner, "Only the contract owner can do this!");
        _;
    }
    
    function add(string memory newFact) public onlyOwner {
        facts.push(newFact);
    }
}
