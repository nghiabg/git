//
//  ChartBoostManager.m
//  CB
//
//  Created by Mike DeSaro on 12/20/11.
//

#import "InAppManager.h"
//#import "InAppMyManager.h"

//void UnitySendMessage( const char * className, const char * methodName, const char * param );

void UnityPause( bool pause );




@implementation InAppManager

///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark NSObject

+ (InAppManager*)sharedManager // vraca singleton objekat
{
	static InAppManager *sharedSingleton;
	
	if( !sharedSingleton )
		sharedSingleton = [[InAppManager alloc] init];
	
	return sharedSingleton;
}


///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark Public

- (void)showAlert:(NSString*) message
{
    NSLog(@"InApp Manager --- Poruka od UNitija: %@", message);
    NSString* messageCommand = @"";
    NSArray* listMessage = [message componentsSeparatedByString:@"###"];
    
    if ([listMessage count] > 0)
    {
        messageCommand = [listMessage objectAtIndex:0];
    }
 
//    if ([message isEqualToString:@"Restore"])
//    {
//        [InAppMyManager btnRestore];
//    }
//    else if ([message isEqualToString:@"Pack1"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Pack1"];
//    }
//    else if ([message isEqualToString:@"Pack2"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Pack2"];
//    }
//    else if ([message isEqualToString:@"Pack3"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Pack3"];
//    }
//    else if ([message isEqualToString:@"Pack4"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Pack4"];
//    }
//    else if ([message isEqualToString:@"Pack5"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Pack5"];
//    }
//    else if ([message isEqualToString:@"BananaSmall"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Banana5"];
//    }
//    else if ([message isEqualToString:@"BananaMedium"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Banana15"];
//    }
//    else if ([message isEqualToString:@"BananaLarge"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Banana50"];
//    }
//    else if ([message isEqualToString:@"Starter"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Starter"];
//    }
//    else if ([message isEqualToString:@"BobosChoice"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.Choice"];
//    }
//    else if ([message isEqualToString:@"RemoveAds"])
//    {
//        [InAppMyManager buyProduct:@"webelinx.BoboEpicTale.InApp.RemoveAds"];
//    }
    

    /*
    if ([message isEqualToString:@"unlockAll"])
    {
        [InAppMyManager buyProduct:@"beauty.PrincessNailMakeoverSalon.InApp.UnlockAll"];
    }
    else if ([message isEqualToString:@"RemoveAds"])
    {
        [InAppMyManager buyProduct:@"beauty.PrincessNailMakeoverSalon.InApp.RemoveAds"];
    }
    else if ([message isEqualToString:@"Restore"])
    {
        [InAppMyManager btnRestore];
    }//*/
    
}


@end
