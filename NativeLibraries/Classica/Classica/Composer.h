//
//  Composer.h
//  Classica
//
//  Created by Yoshihiro Tanaka on 2017/02/04.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Composer : NSObject

@property (assign, nonatomic, readonly) NSInteger id;

@property (strong, nonatomic, readonly) NSString *name;

@property (assign, nonatomic, readonly) NSInteger birth;

@property (assign, nonatomic, readonly) NSInteger death;

@property (strong, nonatomic, readonly) NSArray *musics;

- (instancetype)initWithId: (NSInteger)id
                      name: (NSString *)name
                     birth: (NSInteger)birth
                     death: (NSInteger)death
                    musics: (NSArray *)musics;

- (instancetype)initWithDictionary: (NSDictionary *)source;

@end
