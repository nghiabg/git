//
//  ChartBoostManager.m
//  CB
//
//  Created by Mike DeSaro on 12/20/11.
//

#import "FlurryManager.h"
//#import "Flurry.h"
//#import "FlurryMonkeyLoging.h"

//void UnitySendMessage( const char * className, const char * methodName, const char * param );

void UnityPause( bool pause );




@implementation FlurryManager

///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark NSObject

+ (FlurryManager*)sharedManager // vraca singleton objekat
{
    static FlurryManager *sharedSingleton;
    
    if( !sharedSingleton )
        sharedSingleton = [[FlurryManager alloc] init];
    
    return sharedSingleton;
}


///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark Public

- (void)showAlert:(NSString*) message
{
    NSLog(@"Flurry Manager --- Poruka od UNitija: %@", message);
    NSString* messageCommand = @"";
    NSArray* listMessage = [message componentsSeparatedByString:@"#"];
    
    if ([listMessage count] > 0)
    {
        messageCommand = [listMessage objectAtIndex:0];
    }
    
    if ([messageCommand isEqualToString:@"FlurryEvents"])
    {
        NSLog(@"USAO GDE TREBA");
        //[FlurryMonkeyLoging logFlurryEventName:[listMessage objectAtIndex:1] key:[listMessage objectAtIndex:2] value:[listMessage objectAtIndex:3]];
        
        //[Flurry logEvent:[listMessage objectAtIndex:1] withParameters:[NSDictionary dictionaryWithObjects:[listMessage objectAtIndex:3] forKeys:[listMessage objectAtIndex:2]]];
    }
    
}


@end
