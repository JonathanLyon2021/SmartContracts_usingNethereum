//SPDX-License-Identifier: MIT
pragma solidity >= 0.7.0 < 0.8.14;

contract ArrayOfFacts {
    string[] private facts;
    address private contractOwner;
     
     constructor() {
        contractOwner = msg.sender;
    }

}