import React from 'react';
import { Box, MenuItem, Menu, Paper } from '@mui/material';
import SettingsOutlinedIcon from '@mui/icons-material/SettingsOutlined';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import { useState } from 'react';
import { Stack } from '@mui/system';

const Header = () => {
  const [menuOpen, setMenuOpen] = useState(false);
  const [anchorEl, setAnchorEl] = useState(null);

  const handleMenuOpen = (event) => {
    setAnchorEl(event.currentTarget);
    setMenuOpen(!menuOpen);
  };

  const handleMenuClose = () => {
    setMenuOpen(false);
  }

  const handleSignout = () => {
    //will be implemented later
    setMenuOpen(false);
  };

  const handleChangePassword = () => {
    //will be implemented later
    setMenuOpen(false);
  };

  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'space-between',
        p: 1,
        backgroundColor: '#274b69',
      }}
    >
      <Typography variant='h4' sx={{ color: 'white', ml: 1 }}>
        Tool Management System
      </Typography>
      <Box sx={{ display: 'flex' }}>
        <IconButton onClick={handleMenuOpen} type='button' sx={{ p: 1 }}>
          <SettingsOutlinedIcon sx={{ color: 'white' }} />
          {menuOpen ? (
            <Stack direction='row' spacing={2}>
              <Paper>
                <Menu open={menuOpen}
                onClose={handleMenuClose}
                anchorEl={anchorEl}>
                  <MenuItem onClick={handleChangePassword}>
                    Change password
                  </MenuItem>
                  <MenuItem onClick={handleSignout}>Signout</MenuItem>
                </Menu>
              </Paper>
            </Stack>
          ) : null}
        </IconButton>
      </Box>
    </Box>
  );
};

export default Header;
