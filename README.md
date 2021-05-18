# NASH Chain of Trust Checker Tool

The TrustChainChecker is a .NET windows application which looks at the windows certificate store (local and current user),
and presents back to the user if it found Medicare Australia (NASH) Root and OCA Certificates, along with any Certificates 
that are under that Chain of Trust.
It looks at both the Test and Production versions of the Medicare Australia Root and OCA Certificates.

## Getting started

Open up the TrustChainChecker.sln solution file in Visual Studio and Run (F5).
This will display what certificates have been found in the windows certificate store.
