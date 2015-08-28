using System;

// Configure the application sign-in manager which is used in this application.
public enum SignInStatus
{
	Success=1,
	LockedOut=2,
	RequiresVerification=3,
	Failure=4
}
