//
//  Composer+Music.m
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import "Composer+Music.h"

@implementation Composer (Music)

- (NSArray *)musicNames {
    NSMutableArray *names = [[NSMutableArray alloc] init];
    [self.musics enumerateObjectsUsingBlock:^(Music *music, NSUInteger idx, BOOL * _Nonnull stop) {
        [names addObject:music.name];
    }];
    return names;
}

@end
