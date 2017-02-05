//
//  Composer.m
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import "Composer.h"
#import "Music.h"

@interface Composer()

@property (assign, nonatomic, readwrite) NSInteger id;

@property (strong, nonatomic, readwrite) NSString *name;

@property (assign, nonatomic, readwrite) NSInteger birth;

@property (assign, nonatomic, readwrite) NSInteger death;

@property (strong, nonatomic, readwrite) NSArray *musics;

@end

@implementation Composer

- (instancetype)initWithId:(NSInteger)id
                      name:(NSString *)name
                     birth:(NSInteger)birth
                     death:(NSInteger)death
                    musics:(NSArray *)musics {
    self = [super init];
    if(self) {
        self.id = id;
        self.name = name;
        self.birth = birth;
        self.death = death;
        self.musics = musics;
    }
    return self;
}

- (instancetype)initWithDictionary:(NSDictionary *)source {
    self = [super init];
    if(self) {
        self.id = [source[@"id"] intValue];
        NSMutableArray *musics = [[NSMutableArray alloc] init];
        __weak __typeof(self) weakSelf = self;
        [source[@"musics"] enumerateObjectsUsingBlock:^(NSDictionary *music, NSUInteger idx, BOOL * _Nonnull stop) {
            [musics addObject:[[Music alloc] initWithDictionary:music composerId:weakSelf.id]];
        }];
        self.name = source[@"name"];
        self.birth = [source[@"birth"] intValue];
        self.death = [source[@"death"] intValue];
        self.musics = musics;
    }
    return self;
}

@end
