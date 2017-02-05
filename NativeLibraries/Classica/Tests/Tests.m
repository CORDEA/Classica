//
//  Tests.m
//  Tests
//
//  Created by Yoshihiro Tanaka on 2017/02/05.
//  Copyright © 2017年 Yoshihiro Tanaka. All rights reserved.
//

#import <XCTest/XCTest.h>
#import "Classica.h"

@interface Tests : XCTestCase

@property (strong, nonatomic) Classica *classica;

@end

@implementation Tests

- (void)setUp {
    [super setUp];
    self.classica = [[Classica alloc] init];
}

- (void)tearDown {
    [super tearDown];
}

- (void)testClassica {
    NSArray *arr = [self.classica composers];
    XCTAssertNotNil(arr);
    XCTAssertEqual(arr.count, 3);
    for (Composer *composer in arr) {
        XCTAssertNotNil(composer.musics);
    }
}

@end
