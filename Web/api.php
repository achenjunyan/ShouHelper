   <?php
$user = $_GET["u"];
    $password = $_GET["p"];
    if($user == "" || $password == "") 
	{
        $user = $_POST["u"];
        $password = $_POST["p"];
    }	
    include_once('./sql.php'); //引入数据库连接模块\
    //通过 lt_ucenter_members 表获取账户密码
    $sql = 'SELECT uid, username, password,email, salt FROM lt_ucenter_members WHERE username="'.$user.'"';
    mysqli_select_db( $conn, 'RUNOOB' );
    $retval = mysqli_query( $conn, $sql );
    if(! $retval )
    {
        die('无法读取数据: ' . mysqli_error($conn));
    }
    while($row = mysqli_fetch_array($retval, MYSQLI_ASSOC))
    {
        $uid = $row['uid'];
        $salt = $row['salt'];
        $username = $row['username'];
        $email = $row['email'];
        $password1 = $row['password'];
    }
	//通过 lt_common_member_profile 表获取个人信息
	$sql = 'SELECT uid, realname, birthprovince,qq, field1, field3, field5, field6,constellation, field3 FROM lt_common_member_profile WHERE uid="'.$uid.'"';
	 mysqli_select_db( $conn, 'RUNOOB' );
    $retval = mysqli_query( $conn, $sql );
	if(! $retval )
    {
        die('无法读取数据: ' . mysqli_error($conn));   //读取错误
    }
    while($row = mysqli_fetch_array($retval, MYSQLI_ASSOC))
    {
        $realname = $row['realname'];
        $birthprovince = $row['birthprovince'];
        $qq = $row['qq'];
        $field1 = $row['field1'];//steam昵称
        $field3 = $row['field3'];//互联昵称
        $field5 = $row['field5'];//标签头衔
        $field6 = $row['field6'];//个性签名
        $constellation = $row['constellation'];
    }
	
	//使用lt_common_member表获取昵称
	$sql = 'SELECT uid, username FROM lt_common_member WHERE uid="'.$uid.'"';  
	 mysqli_select_db( $conn, 'RUNOOB' );
    $retval = mysqli_query( $conn, $sql );
	if(! $retval )
    {
        die('无法读取数据: ' . mysqli_error($conn));
    }
    while($row = mysqli_fetch_array($retval, MYSQLI_ASSOC))
    {
        $username2 = $row['username'];
    }
    
    	//通过 lt_common_onlinetime 表获取个人信息
	$sql = 'SELECT thismonth,total FROM lt_common_onlinetime WHERE uid="'.$uid.'"';
	 mysqli_select_db( $conn, 'RUNOOB' );
    $retval = mysqli_query( $conn, $sql );
	if(! $retval )
    {
        die('无法读取数据: ' . mysqli_error($conn));   //读取错误
    }
    while($row = mysqli_fetch_array($retval, MYSQLI_ASSOC))
    {
        $thismonth= $row['thismonth'];
        $total = $row['total'];
    }
    $password = md5(md5($password).$salt);
    if($password == $password1) {
        //密码匹配，返回个人信息
        $arr = array($uid,$username,$username2,$email,$constellation,$qq,$realname,$birthprovince,$field1,$field3,$field5, $field6,$thismonth,$total);
        echo json_encode($arr,JSON_UNESCAPED_UNICODE);
    }else {
        echo "password Error";
    }
    mysqli_close($conn);
?>
