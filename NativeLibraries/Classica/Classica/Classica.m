//
//  Classica.m
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import "Classica.h"

@implementation Classica

- (instancetype)init
{
    self = [super init];
    if (self) {
        self.composers = [self getComposers];
        self.musics = [self getMusics];
    }
    return self;
}

- (Composer *)getComposer:(NSInteger)id {
    for (Composer *composer in self.composers) {
        if (composer.id == id) {
            return composer;
        }
    }
    return nil;
}

- (Music *)getMusic:(NSInteger)id {
    for (Music *music in self.musics) {
        if (music.id == id) {
            return music;
        }
    }
    return nil;
}

- (NSArray *) getMusics {
    NSMutableArray *arr = [[NSMutableArray alloc] init];
    [self.composers enumerateObjectsUsingBlock:^(Composer *composer, NSUInteger idx, BOOL * _Nonnull stop) {
        [arr addObjectsFromArray:composer.musics];
    }];
    return arr;
}

- (NSArray *) getComposers {
    NSString *filename = [[NSBundle bundleForClass:[self class]] pathForResource:@"classica" ofType:@"json"];
    NSMutableArray *arr = [[NSMutableArray alloc] init];
    if (!filename) {
        return arr;
    }
    NSData *data = [[NSData alloc] initWithContentsOfFile:filename];
    NSDictionary *jsonDict = [NSJSONSerialization JSONObjectWithData:data
                                                             options:NSJSONReadingAllowFragments
                                                               error:nil];
    if (!jsonDict) {
        return arr;
    }
    
    NSArray *composers = jsonDict[@"composers"];
    [composers enumerateObjectsUsingBlock:^(NSDictionary *composer, NSUInteger idx, BOOL * _Nonnull stop) {
        [arr addObject: [[Composer alloc] initWithDictionary:composer]];
    }];
    return [arr copy];
}

@end
