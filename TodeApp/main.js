const app = new Vue({
    el: '#app',
    data:{
        user:{},
        isLogin:false,
        screen:"login",
        urlApi:"https://localhost:7292/api",
        auth:{
            status:false,
            username:"073",
            password:"123456"
        },
        todos:[],
        statusSave:false,
        todoModel:{
            id:null,
            name:null,
            is_active:false,
        }
    },
    methods: {
        checkLogin(){
            const token = localStorage.getItem("token");
            const user = localStorage.getItem("user");
            if(token!=undefined&&token!=null&&token!=""){
                this.isLogin = true;
                this.screen = "list";
                this.user = JSON.parse(user);
                // console.log("user",this.user );
            }else{
                this.isLogin = false;
                this.screen = "login";
                this.user = new Object();
            }
            // console.log("checkLogin",this.isLogin);
        },
        buttonLogout(){
            localStorage.clear();
            this.isLogin = false;
            this.screen = "login";
            this.user = new Object();
        },
        async buttonLogin(){
            this.auth.status = true;
            var res = await axios.post(this.urlApi+"/auth/login",this.auth);
            console.log(res.data);
            if(res.data){
                this.screen = "list";
                localStorage.setItem("token",res.data.token);
                this.user = res.data
                localStorage.setItem("user",JSON.stringify(res.data));
                this.auth.status = false;
                this.isLogin = true;
                window.location.reload();
                await this.getListDevice();
            }else{
                this.screen = "login"
                alert("Thông đăng nhập không hợp lệ");
                this.auth.status = false;
            }
        },
        async getListTodo(){
            if(this.isLogin){
                try {
                    axios.defaults.headers.common['Authorization'] = `Bearer ${this.user.token}`;
                    var res = await axios.get(this.urlApi+"/todo/getAll");
                    if(res!=undefined){
                        this.todos=res.data.todos
                    }
                } catch (error) {
                    this.isLogin = false;
                }
                
            }
        },
        buttonUpdate(data){
            this.todoModel = data;
            this.screen = "AddAndUpdate";
        },
        buttonAdd(){
            this.statusSave = false;
            this.todoModel.id="";
            this.todoModel.name="";
            this.todoModel.is_active=false;
            this.screen = "AddAndUpdate";
        },
        buttonBack(data){
            this.statusSave = false;
            this.screen = data;
        },
        async buttonSave(){
            if(this.todoModel.name==""){
                alert("Vui lòng nhập tên");
                return false;
            }
            if(this.todoModel.is_active=="false"){
                this.todoModel.is_active = false
            }
            if(this.todoModel.is_active=="true"){
                this.todoModel.is_active = true
            }
            this.statusSave = true;
            if(this.todoModel.id==""||this.todoModel.id==null){
                try {
                    delete this.todoModel.id
                    axios.defaults.headers.common['Authorization'] = `Bearer ${this.user.token}`;
                    var res = await axios.post(this.urlApi+"/todo/add",this.todoModel);
                    if(res.data.status){
                        this.statusSave = false;
                        this.screen = "list";
                        this.getListTodo();
                    }else{
                        this.statusSave = false;
                        alert(res.data.message);
                    }
                } catch (error) {
                    this.isLogin = false;
                }
            }else{
                try {
                    axios.defaults.headers.common['Authorization'] = `Bearer ${this.user.token}`;
                    var res = await axios.post(this.urlApi+"/todo/edit",this.todoModel);
                    if(res.data.status){
                        this.statusSave = false;
                        this.screen = "list";
                        this.getListTodo();
                    }
                    else{
                        alert(res.data.message);
                        this.statusSave = false;
                    }
                } catch (error) {
                    this.isLogin = false;
                }
            }
        },
        async buttonDelete(item){
            try {
                if (confirm("Bạn có muốn xóa không") == true) {
                    axios.defaults.headers.common['Authorization'] = `Bearer ${this.user.token}`;
                    var res = await axios.post(this.urlApi+"/todo/delete",{
                        id:item.id
                    });
                    if(res.data.status){
                        this.screen = "list";
                        this.getListTodo();
                    }
                  } else {
                    
                  }
               
            } catch (error) {
                this.screen = "list";
            }
        }
    },
    created() {
        this.checkLogin();
        this.getListTodo();
    },
})
