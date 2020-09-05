export default function (id, fields) {
    return {
        watch: fields.reduce((obj, field) => {
            //  侦听处理函数
            obj[field] = function (val) {
                localStorage.setItem(`${id}.${field}`, JSON.stringify(val))
            };
            return obj;
        }, {}),
        methods: {
            saveAllPersiatantData() {
                for (const field of fields) {
                    localStorage.setItem(`${id}.${field}`, JSON.stringify(this.$data[field]));
                }
            }
        },
        beforeDestory() {
            this.saveAllPersiatantData();
        },
        created() {
            for (const field of fields) {
                const savedValue = localStorage.getItem(`${id}.${field}`);
                if (savedValue !== null) {
                    this.$data[field] == JSON.parse(savedValue);
                }
            }
        }
    }
}