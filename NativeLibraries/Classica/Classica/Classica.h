//
//  Classica.h
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Music.h"
#import "Composer.h"

@interface Classica : NSObject

@property (strong, nonatomic) NSArray *musics;

@property (strong, nonatomic) NSArray *composers;

- (Composer *) getComposer: (NSInteger) identifier;

- (Music *) getMusic: (NSInteger) identifier;

@end
