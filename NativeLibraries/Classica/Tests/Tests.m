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
    NSArray *composers = [self.classica composers];
    NSArray *musics = [self.classica musics];
    XCTAssertNotNil(composers);
    XCTAssertEqual(composers.count, 3);
    XCTAssertEqual(musics.count, 10);
}

- (void)testComposer1 {
    NSArray *arr = [self.classica composers];
    Composer *composer1 = arr[0];
    XCTAssertEqual(composer1.id, 0);
    XCTAssertEqualObjects(composer1.name, @"Antonio Lucio Vivaldi");
    XCTAssertEqual(composer1.musics.count, 4);
    
    Music *music1 = composer1.musics[0];
    XCTAssertEqual(music1.id, 0);
    XCTAssertEqual(music1.composerId, 0);
    Music *music2 = composer1.musics[1];
    XCTAssertEqual(music2.id, 1);
    XCTAssertEqual(music2.composerId, 0);
    Music *music3 = composer1.musics[2];
    XCTAssertEqual(music3.id, 2);
    XCTAssertEqual(music3.composerId, 0);
    Music *music4 = composer1.musics[3];
    XCTAssertEqual(music4.id, 3);
    XCTAssertEqual(music4.composerId, 0);
}

- (void)testComposer2 {
    NSArray *arr = [self.classica composers];
    Composer *composer2 = arr[1];
    XCTAssertEqual(composer2.id, 1);
    XCTAssertEqualObjects(composer2.name, @"Franz Joseph Haydn");
    XCTAssertEqual(composer2.musics.count, 3);
    
    Music *music5 = composer2.musics[0];
    XCTAssertEqual(music5.id, 4);
    XCTAssertEqual(music5.composerId, 1);
    Music *music6 = composer2.musics[1];
    XCTAssertEqual(music6.id, 5);
    XCTAssertEqual(music6.composerId, 1);
    Music *music7 = composer2.musics[2];
    XCTAssertEqual(music7.id, 6);
    XCTAssertEqual(music7.composerId, 1);
}

- (void)testComposer3 {
    NSArray *arr = [self.classica composers];
    Composer *composer3 = arr[2];
    XCTAssertEqual(composer3.id, 2);
    XCTAssertEqualObjects(composer3.name, @"Wolfgang Amadeus Mozart");
    XCTAssertEqual(composer3.musics.count, 3);
    
    Music *music8 = composer3.musics[0];
    XCTAssertEqual(music8.id, 7);
    XCTAssertEqual(music8.composerId, 2);
    Music *music9 = composer3.musics[1];
    XCTAssertEqual(music9.id, 8);
    XCTAssertEqual(music9.composerId, 2);
    Music *music10 = composer3.musics[2];
    XCTAssertEqual(music10.id, 9);
    XCTAssertEqual(music10.composerId, 2);
}

@end
