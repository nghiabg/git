//
//  ChartBoostManager.m
//  CB
//
//  Created by Mike DeSaro on 12/20/11.
//

#import "OtherMessagesManager.h"
//#import "TwitterManager.h"
//#import "InstagramManager.h"
//#import "SaveToGallery.h"

//void UnitySendMessage( const char * className, const char * methodName, const char * param );

void UnityPause( bool pause );




@implementation OtherMessagesManager

///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark NSObject

+ (OtherMessagesManager*)sharedManager // vraca singleton objekat
{
	static OtherMessagesManager *sharedSingleton;
	
	if( !sharedSingleton )
		sharedSingleton = [[OtherMessagesManager alloc] init];
	
	return sharedSingleton;
}


///////////////////////////////////////////////////////////////////////////////////////////////////
#pragma mark Public

- (void)showAlert:(NSString*) message
{
    NSLog(@"Other Messages Manager --- Poruka od UNitija: %@", message);
//    NSString* messageCommand = @"";
//    NSArray* listMessage = [message componentsSeparatedByString:@"###"];
    
//    if ([listMessage count] > 1)
//    {
        //Ovde obradjujemo  poruke koje su stigle sa separatorom @"###"
//        messageCommand = [listMessage objectAtIndex:0];
        
//        if ([messageCommand isEqualToString:@"SaveToGallery"])
//        {
//            [[SaveToGallery sharedSaveToGallery] saveToGalleryFromDocumentWithName:[listMessage objectAtIndex:1]];
//        }
//        else if ([messageCommand isEqualToString:@"ShareToTwitter"])
//        {
//            NSString* msg = @"";
//            if ([listMessage count] > 2)
//            {
//                msg = [listMessage objectAtIndex:2];
//            }
//            
//            [[TwitterManager sharedTwitterManager] sendTwittWithPicture:[listMessage objectAtIndex:1] postText:msg];
//        }
//        else if ([messageCommand isEqualToString:@"ShareToInstagram"])
//        {
//            NSString* msg = @"";
//            if ([listMessage count] > 2)
//            {
//                msg = [listMessage objectAtIndex:2];
//            }
//            
//            [[InstagramManager sharedInstagramManager] sendInstagramWithPicture:[listMessage objectAtIndex:1] postText:msg];
//        }
//    }//*/
    if([message isEqualToString:@"CheckForFBApp"])
    {
        if ([[UIApplication sharedApplication] canOpenURL:[NSURL URLWithString:@"fb://"]])
        {
            UnitySendMessage("WebelinxCMS","CheckForFBAppResult","true");
        }
        else
        {
            UnitySendMessage("WebelinxCMS","CheckForFBAppResult","false");
        }
    }
}


@end
