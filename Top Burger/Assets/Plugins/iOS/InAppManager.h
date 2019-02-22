//
//  ChartBoostManager.h
//  CB
//
//  Created by Mike DeSaro on 12/20/11.
//


#import <Foundation/Foundation.h>
#import "UnityAppController.h"



@interface InAppManager : NSObject <UIAlertViewDelegate>


+ (InAppManager*)sharedManager;

- (void)showAlert:(NSString*) message;

@end
