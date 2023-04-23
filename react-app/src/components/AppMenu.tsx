import {
    Box,
    AppBar,
    Toolbar,
    IconButton,
    Typography,
    Button,
} from "@mui/material";
import {Link, useLocation} from "react-router-dom";
import HomeIcon from "@mui/icons-material/Home";
import AccountCircleIcon from "@mui/icons-material/AccountCircle";
import AttachMoneyIcon from "@mui/icons-material/AttachMoney";
import React from "react";

export const AppMenu = () => {
    const location = useLocation();
    const path = location.pathname;

    return (
        <Box sx={{flexGrow: 1}}>
            <AppBar position="static">
                <Toolbar>
                    <IconButton
                        component={Link}
                        to="/"
                        size="large"
                        edge="start"
                        color="inherit"
                        aria-label="menu"
                        sx={{mr: 2}}
                    >
                        <HomeIcon />
                    </IconButton>
                    <Typography
                        variant="h6"
                        component="div"
                        sx={{flexGrow: 1}}
                    >
                        Music Management
                    </Typography>
                    <Button
                        variant={path.startsWith("/Album") ? "outlined" : "text"}
                        to="/Album"
                        component={Link}
                        color = "inherit"
                        sx={{mr: 2}}
                        startIcon={<AccountCircleIcon />}
                        >
                            Albums
                        </Button>

                        <Button
                            variant={path.startsWith("/AlbumFilter") ? "outlined" : "text"}
                            to="/AlbumFilter"
                            component={Link}
                            color = "inherit"
                            sx={{mr: 2}}
                            startIcon={<AttachMoneyIcon />}
                            >
                                Filter by Price
                            </Button>
                </Toolbar>
            </AppBar>
        </Box>
    );
};
