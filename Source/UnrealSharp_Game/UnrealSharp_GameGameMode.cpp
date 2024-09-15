// Copyright Epic Games, Inc. All Rights Reserved.

#include "UnrealSharp_GameGameMode.h"
#include "UnrealSharp_GameCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUnrealSharp_GameGameMode::AUnrealSharp_GameGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
