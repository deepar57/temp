const option1 = new RegExp("pattern", "gmi")
const option2 = /pattern/gmi

const str = "123 abc"

const regexp = /abc/
regexp.test(str) // true
const regexp = /33/
regexp.test(str) // false

str.replace(regexp, "123")
