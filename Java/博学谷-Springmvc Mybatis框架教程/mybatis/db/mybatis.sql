/*
 Navicat Premium Data Transfer

 Source Server         : Joseph-Server-MySQL
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : 49.235.249.194:3306
 Source Schema         : mybatis

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 25/11/2020 13:33:55
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for items
-- ----------------------------
DROP TABLE IF EXISTS `items`;
CREATE TABLE `items`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '商品名称',
  `price` float(10, 1) NOT NULL COMMENT '商品定价',
  `detail` text CHARACTER SET utf8 COLLATE utf8_general_ci NULL COMMENT '商品描述',
  `pic` varchar(512) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '商品图片',
  `createtime` datetime(0) NULL DEFAULT NULL COMMENT '生产日期',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of items
-- ----------------------------
INSERT INTO `items` VALUES (1, '笔记本45', 4000.0, '质量不错', NULL, NULL);
INSERT INTO `items` VALUES (2, '笔记本3', 6000.0, NULL, NULL, NULL);
INSERT INTO `items` VALUES (3, '背包背包', 200.0, '名牌背包，容量大...', NULL, NULL);

-- ----------------------------
-- Table structure for orderdetail
-- ----------------------------
DROP TABLE IF EXISTS `orderdetail`;
CREATE TABLE `orderdetail`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `orders_id` int(0) NOT NULL COMMENT '订单id',
  `items_id` int(0) NOT NULL COMMENT '商品id',
  `items_num` int(0) NULL DEFAULT NULL COMMENT '商品购买数量',
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `FK_orderdetail_1`(`orders_id`) USING BTREE,
  INDEX `FK_orderdetail_2`(`items_id`) USING BTREE,
  CONSTRAINT `FK_orderdetail_1` FOREIGN KEY (`orders_id`) REFERENCES `orders` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_orderdetail_2` FOREIGN KEY (`items_id`) REFERENCES `items` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orderdetail
-- ----------------------------
INSERT INTO `orderdetail` VALUES (2, 3, 1, 1);
INSERT INTO `orderdetail` VALUES (3, 3, 2, 3);
INSERT INTO `orderdetail` VALUES (4, 4, 3, 4);
INSERT INTO `orderdetail` VALUES (5, 4, 2, 3);

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `user_id` int(0) NOT NULL COMMENT '下单用户id',
  `number` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '订单号',
  `createtime` datetime(0) NOT NULL COMMENT '创建订单时间',
  `note` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `FK_orders_id`(`user_id`) USING BTREE,
  CONSTRAINT `FK_orders_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES (3, 1, '1000010', '2015-02-04 13:22:35', NULL);
INSERT INTO `orders` VALUES (4, 1, '1000011', '2015-02-03 13:22:41', NULL);
INSERT INTO `orders` VALUES (5, 10, '1000012', '2015-02-12 16:13:23', NULL);

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `id` int(0) NOT NULL AUTO_INCREMENT,
  `username` varchar(65) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '用户名称',
  `birthday` date NULL DEFAULT NULL COMMENT '生日',
  `sex` char(1) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '性别',
  `address` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '地址',
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 41 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES (1, '测试用户22', NULL, NULL, NULL);
INSERT INTO `user` VALUES (10, 'Test', '2020-10-26', '1', '河南郑州');
INSERT INTO `user` VALUES (21, '张小明', NULL, '1', '河南郑州');
INSERT INTO `user` VALUES (22, '陈小明', NULL, '1', '河南郑州');
INSERT INTO `user` VALUES (25, '陈小明', NULL, '1', '河南郑州');
INSERT INTO `user` VALUES (33, '张小明', NULL, '1', '河南郑州');
INSERT INTO `user` VALUES (36, '王大军', '2020-10-28', '2', '河南郑州');
INSERT INTO `user` VALUES (37, '王小军', '2020-10-26', '1', '河南郑州');
INSERT INTO `user` VALUES (38, '王小军', '2020-10-26', '1', '河南郑州');
INSERT INTO `user` VALUES (39, '张三丰', NULL, '1', '河南郑州');
INSERT INTO `user` VALUES (40, '张三丰', NULL, '1', '河南郑州');

SET FOREIGN_KEY_CHECKS = 1;
