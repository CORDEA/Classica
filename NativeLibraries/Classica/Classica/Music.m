//
//  Music.m
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import "Music.h"

@interface Music()

@property (assign, nonatomic, readwrite) NSInteger id;

@property (assign, nonatomic, readwrite) NSInteger composerId;

@property (strong, nonatomic, readwrite) NSString *name;

@property (assign, nonatomic, readwrite) NSInteger year;

@property (strong, nonatomic, readwrite) NSString *opusNumber;

@end

@implementation Music

- (instancetype)initWithId:(NSInteger)id
                composerId: (NSInteger)composerId
                      name:(NSString *)name
                      year:(NSInteger)year
                opusNumber:(NSString *)opusNumber {
    self = [super init];
    if(self)
    {
        self.id = id;
        self.composerId = composerId;
        self.name = name;
        self.year = year;
        self.opusNumber = opusNumber;
    }
    return self;
}

- (instancetype)initWithDictionary:(NSDictionary *)source {
    self = [super init];
    if(self) {
        self.id = [source[@"id"] intValue];
        self.composerId = [source[@"composerId"] intValue];
        self.name = source[@"name"];
        self.year = [source[@"year"] intValue];
        self.opusNumber = source[@"opusNumber"];
    }
    return self;
}

@end
