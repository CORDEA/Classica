//
//  Music.h
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Music : NSObject

@property (assign, nonatomic, readonly) NSInteger id;

@property (assign, nonatomic, readonly) NSInteger composerId;

@property (strong, nonatomic, readonly) NSString *name;

@property (assign, nonatomic, readonly) NSInteger year;

@property (strong, nonatomic, readonly) NSString *opusNumber;

- (instancetype)initWithId: (NSInteger)id
                composerId: (NSInteger)composerId
                      name: (NSString *)name
                      year: (NSInteger)year
                opusNumber: (NSString *)opusNumber;

- (instancetype)initWithDictionary:(NSDictionary *)source composerId:(NSInteger)composerId;

@end

