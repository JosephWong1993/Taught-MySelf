Vue.component('vTable', {
    props: {
        columns: {
            type: Array,
            default: function () {
                return [];
            }
        },
        data: {
            type: Array,
            default: function () {
                return [];
            }
        }
    },
    data: function () {
        return {
            currentColumns: [],
            currentData: []
        }
    },
    methods: {
        makeColumns() {
            this.currentColumns = this.columns.map(function (col, index) {
                //  添加一个字段标识当前排序的状态,后续使用
                col._sortType = 'normal';
                //  添加一个字段标识当前列在数组中的索引,后续使用
                col._index = index;
                return col;
            })
        },
        makeData() {
            this.currentData = this.data.map(function (row, index) {
                //  添加一个字段标识当前行在数组中的索引,后续使用
                row._index = index;
                return row;
            })
        },
        handleSort: function (index, type = 'asc') {
            var key = this.currentColumns[index].key;
            this.currentColumns.forEach(function (col) {
                col._sortType = 'normal';
            });
            this.currentColumns[index]._sortType = type;
            this.currentData.sort(function (a, b) {
                if (!!type && type == 'asc') {
                    return a[key] > b[key] ? 1 : -1;
                } else {
                    return a[key] < b[key] ? 1 : -1;
                }
            });
        }
    },
    mounted() {
        //  v-table初始化时调用
        this.makeColumns();
        this.makeData();
    },
    render: function (h) {
        var _this = this;
        var ths = [];
        var trs = [];
        this.currentColumns.forEach(function (col, index) {
            if (col.sortable) {
                ths.push(h('th', [
                    h('span', col.title),
                    //  升序
                    h('a', {
                        class: {
                            on: col._sortType === 'asc'
                        },
                        on: {
                            click: function () {
                                _this.handleSort(index, 'asc');
                            }
                        }
                    }, '↑'),
                    //  降序
                    h('a', {
                        class: {
                            on: col._sortType === 'desc'
                        },
                        on: {
                            click: function () {
                                _this.handleSort(index, 'desc');
                            }
                        }
                    }, '↓'),
                ]))
            } else {
                ths.push(h('th', col.title));
            }
        })
        this.currentData.forEach(row => {
            var tds = [];
            _this.currentColumns.forEach(function (cell) {
                tds.push(h('td', row[cell.key]));
            });
            trs.push(h('tr', tds));
        });
        return h('table', [
            h('thead', [
                h('tr', ths)
            ]),
            h('tbody', trs)
        ])
    },
    watch: {
        data: function () {
            this.makeData();
            var sortedColumn = this.currentColumns.filter(function (col) {
                return col._sortType != 'normal';
            });

            if (sortedColumn.length > 0) {
                this.handleSort(sortedColumn[0]._index, sortedColumn[0]._sortType)
            }
        }
    }
});